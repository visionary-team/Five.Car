// pages/order_details/order_details.js
Page({
  /**
   * 页面的初始数据
   */
  data: {
  },

  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function(options) {
    var that = this
    var id = parseInt(options.cid)
    wx.request({
      url: 'http://localhost:52631/api/Order/GetOrdersById?id=' + id,
      method: 'get',
      success: function(res) {
          that.setData({
            CarDetail: res.data
          })
      }
    })
  },

  go: function(e) {
    var id = e.currentTarget.dataset.aid
    wx.showModal({
      title: '提示付款',
      content: '确定要付款吗？',
      cancelColor: '#0076FF',
      confirmColor: '#0076FF',
      success: function(sm) {
        if (sm.confirm) {
          wx.request({
            url: 'http://localhost:52631/api/Order/UpdateCarOrderState',
            method: "get",
            data:{id:id},
            success: function(res) {
              wx.showToast({
                title: '付款成功!',//提示付款成功，状态成功修改
                icon:"success",
                duration: 2000,
              })
            }
          })
        }
        
        else if(sm.cancel){
          console.log("用户点击取消");
        }
      }
    })
    setTimeout(function() {
      wx.navigateTo({
        url: '../Order_form/order_form',
      },1000)
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