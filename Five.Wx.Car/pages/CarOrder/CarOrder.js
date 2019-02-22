// pages/CarOrder/CarOrder.js
Page({

  /**
   * 页面的初始数据
   */
  data: {
  },
  addOrder:function(e){
    var that=this;
    var price = e.currentTarget.dataset.price;
    var cid = e.currentTarget.dataset.cid;
    wx.getStorage({
      key: 'uName',
      success: function(res) {
        wx.request({
          url: 'http://localhost:52631/api/Order/Add',
          method: "get",
          data: {
            Price: price,
            Carid: cid,
            Useid:res.data
          },
          success: function (res) {
            wx.navigateTo({
              url: '../Confirm_Pay/Confirm_Pay?cid='+cid,
            })
          }
        })
      },
    })
  },

  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {
    var that = this;
    wx.getStorage({
      key: 'uName',
      success: function(res) {
        wx.request({
          url: 'http://localhost:52631/api/Collect/ShowAddress',
          method: "get",
          data:{
            userId:res.data
          },
          success: function (res) {
          
            that.setData({
              lunbo: res.data
            })
          }
        })
      },
    })
   
    var carid=parseInt(options.cid)
    var thats = this;
    wx.request({
      url: 'http://localhost:52631/api/Collect/ShowOrders',
      method: "get",
      data: { id: carid },
      success: function (col) {
        thats.setData({
          lunbos: col.data
        })
      }
    })
  },

  /**
   * 生命周期函数--监听页面初次渲染完成
   */
  onReady: function () {

  },

  /**
   * 生命周期函数--监听页面显示
   */
  onShow: function () {

  },

  /**
   * 生命周期函数--监听页面隐藏
   */
  onHide: function () {

  },

  /**
   * 生命周期函数--监听页面卸载
   */
  onUnload: function () {

  },

  /**
   * 页面相关事件处理函数--监听用户下拉动作
   */
  onPullDownRefresh: function () {

  },

  /**
   * 页面上拉触底事件的处理函数
   */
  onReachBottom: function () {

  },

  /**
   * 用户点击右上角分享
   */
  onShareAppMessage: function () {

  }
})