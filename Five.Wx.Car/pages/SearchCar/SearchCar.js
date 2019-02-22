// pages/Car searching/Car searching.js
Page({

  /**
   * 页面的初始数据
   */
  data: {

  },
  jumppage: function (e) {
    var pid = e.currentTarget.dataset.pid;
    wx.navigateTo({
      url: '../Car_details/Car_details?Pid=' + pid,
    })

  },
  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {
    var cid =parseInt(options.cid);
    var that = this;
    wx.request({
      url: 'http://localhost:52631/api/CarDetails/GetCarShopsByCid',
      method: "Get",
      data:{
        cid:cid
      },
      success: function (res) {
        that.setData({
          CarAllDetail: res.data
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