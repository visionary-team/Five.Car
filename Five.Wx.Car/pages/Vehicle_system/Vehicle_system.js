// pages/Vehicle_system/Vehicle_system.js
Page({

  /**
   * 页面的初始数据
   */
  data: {
    car_brand:[{
      name:"奔驰A6"
    },{
      name: "奔驰A5"
      },{
      name: "奔驰A5"
      }]
  },

  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {
    var pid=parseInt(options.Pid);
    var name = options.name;
    var that=this;
    wx.request({
      url: 'http://localhost:52631/api/CarDetails/CarBrandShow?Pid='+pid,
      method: "Get",
      data: {},
      success: function (res) {
        console.log(res);
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