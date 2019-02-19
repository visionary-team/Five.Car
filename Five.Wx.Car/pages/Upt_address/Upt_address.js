// pages/Upt_address/Upt_address.js
Page({
  
  /**
   * 页面的初始数据
   */
  data: {

    // 省市区三级联动初始化
    region: ["", "", ""],
    name: '',//收货人
    phone: '',//收货人手机号
    street: '',//收货地
    id: ''
  },

  //省市县
  changeRegin: function (e) {
    this.setData({ region: e.detail.value });
    console.log(this.data.region);
  },


  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {
    var that = this;
     this.data.id=parseInt(options.Id);
    wx.request({
      url: 'http://localhost:52631/api/Address/GetAddressById?Id=' + this.data.id,
      method:'get',
      success:function(res)
      {
        console.log(res);
        that.setData({
          lunbo:res.data
        })
      }
    })
  },

  /**
   * 生命周期函数--监听页面初次渲染完成
   */
  onReady: function () {

  },

  //修改
  handleSubmit:function(e)
  {
    var name = e.detail.value.delivery_name;
    var phone = e.detail.value.delivery_phone;
    var street = e.detail.value.delivery_street;
    var id = this.data.id;
    console.log(id);
    wx.request({
      url: 'http://localhost:52631/api/Address/UptAddress',
      method:"get",
      data:{
        Id: id,
        UName:name,
        Phone: phone,
        Province:this.data.region,
        UserAddress:street,
      },
      success:function(res)
      {
        console.log(res);
        wx.showModal({
          title: '提示', 
          content: '修改成功',
        })
      }
      
    })
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