// pages/Add_Evaluation/Add_Evaluation.js
Page({

  /**
   * 页面的初始数据
   */
  data: {
    selectPerson: true,
    firstPerson: '请选择',
    selectArea: false,
    content:'',
    state:'',
    cardetailsid:'',
  },
  //点击选择类型
  clickPerson: function () {
    var selectPerson = this.data.selectPerson;
    if (selectPerson == true) {
      this.setData({
        selectPerson: false,
      })
    } else {
      this.setData({   
        selectPerson: true,
      })
    }
  },
  //点击切换
  mySelect: function (e) {
    this.setData({
      firstPerson: e.target.dataset.me,
      selectPerson: true,
      selectArea: false,
    })
  },
  
  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {
    var that = this;
       wx.request({
         url: 'http://localhost:52631/api/Evaluate/GetCarDetails',
         method:'get',
         data:{},
         success:function(res)
         {
           console.log(res),
           that.setData({
             lunbo:res.data
           })
         }
       })
  },

  handleSubmit:function(e)
  {
    var content = e.detail.value.delivery_content;
    var isdelete=0;
    var state = this.data.selectPerson;
    var cardetailsid=1;

    wx.request({
      url: 'http://localhost:52631/api/Evaluate/Add',
      data: {
        Content: content,
        Isdelete: isdelete,
        State: state,
        CarDetailsId: cardetailsid
      },
      method: 'GET',
      success: function() {
          wx.showModal({
            title: '提示',
            content: '添加成功',
          })
      },
      fail: function() {
        wx.showModal({
          title: '提示',
          content: '添加失败',
        })
      },
      
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