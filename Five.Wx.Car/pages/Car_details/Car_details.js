
Page({

  /**
   * 页面的初始数据
   */
  data: {

  },
  GoPay:function(){
    wx.navigateTo({
      url: '../CarOrder/CarOrder',
    })
  },

  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {
    var pid = parseInt(options.Pid);
    var that = this;
    wx.request({
      url: 'http://localhost:52631/api/CarDetails/GetCarShopsById?id='+pid,
      method: "Get",
      data: {},
      success: function (res) {
        that.setData({
          CarDetail: res.data
        })
      }
    })
  },
  collect:function(e){
    var id = e.currentTarget.dataset.id;
    var collection = e.currentTarget.dataset.collection;
    console.log(id, collection);
    wx.request({
      url: 'http://localhost:52631/api/Collect/UpdateCarCollection',
      method: "Get",
      data: { id: id, isCollection: collection},
      success: function (res) {
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