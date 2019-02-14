// pages/Add_address/Add_address.js
Page({

  /**
   * 页面的初始数据
   */
  data: {
    
      // 省市区三级联动初始化
      region: ["河南省", "周口市", "西华县"],   
       name : '',//收货人
       phone : '',//收货人手机号
       street : ''//收货地
      
  },
   
   //省市县
  changeRegin:function(e)
  {
     this.setData({region:e.detail.value});
  },

   
  
   

  //手机号
  changephone: function (e)
  {
    let phone = e.detail.value;
    if (phone.length==11)
     {
      let checkedNum = this.checkphoneNum(phone)
     }
     else{
      wx.showToast({
        title: '手机号位数不对',
      })
     }
  },

  checkphoneNum: function (phone) {
    var str = /^1(3|4|5|7|8)\d{9}$/;
    if (str.test(phone)) {
         return true;
    }   
    else
    {
      wx.showToast({
        title: '手机号不正确',
      })
      return false;
    }
  },

  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {
      
  },
   
  handleSubmit: function (e) {

    var name = e.detail.value.delivery_name;
    var phone = e.detail.value.delivery_phone;
    var street = e.detail.value.delivery_street;
    wx: if (name == "" || phone == "" || street == "") {
      wx.showModal({
        title: '提示',
        content: '请输入完整信息',
      })
    }
    else {
      console.log(e.detail.value)
    }
    
     wx.request({
       url: 'http://localhost:52631/api/Address/AddressDetails',
       method: "get",
       data: {
         UName: name,
         Phone: phone,
         Province: this.data.region,
         UserAddress: street
       },
       success: function () {
        wx.showToast({
          title: '添加成功',
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