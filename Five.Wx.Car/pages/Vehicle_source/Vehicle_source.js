// pages/Vehicle_source/Vehicle_source.js
Page({

  /**
   * 页面的初始数据
   */
  data: {
    hotCar:[{
      imgUrl:"/Img/大众/大众1.jpg",
      name:"大众",
    },
      {
        imgUrl: "/Img/宾利/宾利1.jpg",
        name: "宾利",
      },
      {
        imgUrl: "/Img/法拉利/法拉利1.jpg",
        name: "法拉利",
      },
      {
        imgUrl: "/Img/红旗/红旗.jpg",
        name: "红旗",
      },
    ],
    allCar:[
      {
        imgUrl: "/Img/大众/大众1.jpg",
        name: "大众",
      },
      {
        imgUrl: "/Img/宾利/宾利1.jpg",
        name: "宾利",
      },
      {
        imgUrl: "/Img/法拉利/法拉利1.jpg",
        name: "法拉利",
      },
      {
        imgUrl: "/Img/红旗/红旗.jpg",
        name: "红旗",
      },
    ]
  },
  jump:function(){
      wx.navigateTo({
        url: '../Vehicle_system/Vehicle_system',
      })
  },

  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {

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