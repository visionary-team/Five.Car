// pages/Vehicle_source/Vehicle_source.js
Page({

  /**
   * 页面的初始数据
   */
  data: {
    
  },
  jump:function(e){
    var pid = e.currentTarget.dataset.pid;
      wx.navigateTo({
        url: '../Vehicle_system/Vehicle_system?Pid=' + pid,
      })
  },
  search:function(e){
    var text=e.detail.value;
    var that = this;
    wx.request({
      url: 'http://localhost:52631/api/CarDetails/CarBrandShow',
      method: "Get",
      data: { Pid: 0, Brand: text },
      success: function (res) {
        that.setData({
          hotCar: res.data
        })
      }
    })
  },
  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {
    var that = this;
    wx.request({
      url: 'http://localhost:52631/api/CarDetails/CarBrandShow',
      method: "Get",
      data: {Pid:0,Brand:""},
      success: function (res) {
        that.setData({
          hotCar: res.data
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