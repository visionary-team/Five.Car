// pages/myorder/myorder.js
Page({

  /**
   * 页面的初始数据
   */
  data: {},
  onLoad() {},
  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function(options) {

  },

  /**
   * 生命周期函数--监听页面初次渲染完成
   */
  onReady: function() {

  },

  /**
   * 生命周期函数--监听页面显示
   */
  onShow: function() {

  },

  /**
   * 生命周期函数--监听页面隐藏
   */
  onHide: function() {

  },

  /**
   * 生命周期函数--监听页面卸载
   */
  onUnload: function() {

  },

  /**
   * 页面相关事件处理函数--监听用户下拉动作
   */
  onPullDownRefresh: function() {

  },

  /**
   * 页面上拉触底事件的处理函数
   */
  onReachBottom: function() {

  },

  /**
   * 用户点击右上角分享
   */
  onShareAppMessage: function() {

  },
  delorder:function(){
    wx.navigateTo({
      url: '../order_details/order_details',
    })
  },
  Pay:function(){
    wx.navigateTo({
      url: '../Confirm_Pay/Confirm_Pay',
    })
  },
  getAllorders: function(options) {
    var that = this;
    wx.request({
      url: 'http://localhost:52631/api/Order/CarOrdreTableAll',
      method: 'get',
      success: function(res) {
        console.log(res.data)
        that.setData({
          items: res.data
        })
      }
    })
  },
  getstates: function(e) {
    var that = this;
    var getid = e.currentTarget.dataset.ids;
    wx.request({
      url: 'http://localhost:52631/api/Order/CarOrdreTable',
      method: 'get',
      data: {
        id: getid
      },
      success: function(res) {
        that.setData({
          items: res.data
        })
      }
    })
  },
})