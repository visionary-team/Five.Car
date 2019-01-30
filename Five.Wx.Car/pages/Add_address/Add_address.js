// pages/Add_address/Add_address.js
Page({

  /**
   * 页面的初始数据
   */
  data: {
    
      // 省市区三级联动初始化
      region: ["四川省", "广元市", "苍溪县"],
   
       delivery_name : '',//收货人
       delivery_phone : '',//收货人手机号
       delivery_street : '',//收货地址
      
  },

  // 选择省市区函数
  changeRegin(e) {
    this.setData({ region: e.detail.value });
  }, 

  //收货人
  changeuname(e)
  {
    this.setData({ delivery_name:e.detail.value});
  },

//手机号
  changephone(e)
  {
    this.setData({delivery_phone:e.detail.value});
  },

//详细地址
  changeaddress(e)
  {
    this.setData({ delivery_street:e.detail.value});
  },

  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {
      
  },
   
   save(e) {
    //  if (this.data.delivery_name == '') {
    //    util.showFailToast({
    //      title: '请输入收货人'
    //    });

    //    return;
    //  }
    //  if (this.data.delivery_phone == '') {
    //    util.showFailToast({
    //      title: '请输入手机号'
    //    })
    //    return;
    //  }
    //  else if (!(/^1(3|4|5|7|8)\d{9}$/.test(this.data.delivery_phone)))
    //  {
    //    util.showFailToast({
    //      title: '手机号格式不正确'
    //    })
    //    return;
    //  }
    //  if (this.data.delivery_street == '') {
    //    util.showFailToast({
    //      title: '请输入地址'
    //    })
    //    return;
    //  }
     wx.request({
       url: 'http://localhost:52631/api/Address/AddressDetails',
       method: "get",
       data: {
         UName: delivery_name,
         Phone: delivery_phone,
         UserAddress: region + delivery_street
       },
       success: function () {
        // wx.showFailToast({
        //    title: '添加成功'
        //})
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