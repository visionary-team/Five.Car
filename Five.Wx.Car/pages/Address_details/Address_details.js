// pages/Address_details/Address_details.js
Page({

  /**
   * 页面的初始数据
   */
  data: {
     
  },
  editAddr:function(e){
    var pid = e.currentTarget.dataset.addrid;
    wx.navigateTo({
      url: '../Upt_address/Upt_address?Id='+pid,     
    })
    console.log(pid)
  },
  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {
       var that = this;
       wx.request({
         url: 'http://localhost:52631/api/Address/GetAddress',
         method:"get",
         data:{},
         success:function(res)
         {
           console.log(res);
           that.setData({
             lunbo: res.data
           })
         }
       })
  },
  addAddress:function(e){
    wx.navigateTo({
      url: '../Add_address/Add_address',
    })
  },
  //删除
  delnew:function(e)
   {
    var pid = e.currentTarget.dataset.aid;
     console.log(pid);
      wx.showModal({
        title: '提示',
        content: '确定要删除吗？',
        cancelColor: '#0076FF',
        confirmColor: '#0076FF',
        success:function(sm){
          //如果点击了确定就可以删除了
          if(sm.confirm)
          {
              wx.request({
                url: 'http://localhost:52631/api/Address/Del?Id=' + pid,
                data:'',
                header:{
                  'content-type':'application/json'
                },
                method:"get",
                success:function(res)
                {
                  console.log(res);
                  wx.showToast({
                    title: '删除成功',//数据返回提示
                    icon:'success',
                    duration:2000
                  })
                
                },
                 fail:function(res){ },
                 complete:function (res){ }
              })
          }
          else if(sm.cancel)
          {
              console.log('用户点击取消');
          }
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