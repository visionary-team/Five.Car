Page({

  /**
   * 页面的初始数据
   */
  //普通选择器列表设置，及初始化
  data: {
    region: ["四川省", "广元市", "苍溪县"],
    multiArray3: [['奥迪', '宝马', '奔驰', '大众', '丰田'], ['A8', '1X', 'Rx', '途观', '卡罗拉']],
    multiIndex3: ['奥迪', 'A8']
  },
  handleSubmit: function () {
    
  },

  //选择汽车品牌函数
  // 选择三级联动
  
  changeMultiPicker3(e) {
    this.setData({ multiIndex3: e.detail.value })
  } ,

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