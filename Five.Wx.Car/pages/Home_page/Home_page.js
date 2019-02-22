// pages/Home page/Home page.js
Page({

  /**
   * 页面的初始数据
   */
  data: {
    autoplay: true,
    interval: 2000,
    duration: 1000
  },

  jumppage: function() {
    wx.navigateTo({
      url: '../Carissue/Carissue',
    })
  },
  jump: function(e) {
    var pid = e.currentTarget.dataset.pid;
    wx.navigateTo({
      url: '../Car_details/Car_details?Pid=' + pid,
    })
  },
  MyOrder: function() {
    wx.navigateTo({
      url: '../Order_form/order_form',
    })
  },

  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function(options) {
    var that = this;
    wx.getStorage({
      key: 'token',
      success: function(res) {
        wx.request({
          url: 'http://localhost:52631/api/CarDetails/GetRotationcharts',
          method: "Get",
          data: {},
          header: {
            'content-type': 'application/json',
            'Authorization': 'BasicAuth ' + res.data
          },
          success: function(res) {
            that.setData({
              lunbo: res.data
            })
          }
        })
      }
    })
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

  }
})