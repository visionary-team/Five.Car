Page({

  /**
   * 页面的初始数据
   */
  //普通选择器列表设置，及初始化
  data: {
  
  },
  // 判定输入为非空字符

  formSubmit: function (e) {
    var qiche = e.detail.value.qiche;

    var yanse = e.detail.value.yanse;

    var pailiang = e.detail.value.pailiang;

    // mobile

    var suozaidi = e.detail.value.suozaidi;

    var jiage = e.detail.value.mobile;

    var tupian = e.detail.value.tupian;

    if (qiche==""||yanse == "" || pailiang == "" || suozaidi == "" || jiage == "" || tupian == "") {

      wx.showModal({

        title: '提示',

        content: '请输入完整信息！',

        success: function (res) {

          if (res.confirm) {

            console.log('用户点击确定')

          }

        }

      })

    } else {

      console.log(e.detail.value)
      // detail

    }
    var a = this.data.region;
    console.log('sdf'+a);
    wx.request({
      url: 'http://localhost:52631/api/Collect/AddCarDetails',
      method:"get",
      data:{
        Brandid: qiche, 
        Carcolorid: yanse,
        Displacement: pailiang,
          Address:suozaidi,
        Price:jiage,
          Imgurl:tupian
      },
      success:function(){
        wx.showToast({
          title: '保存成功！',
        })
      }
    })

  },

      

  //表单提交
  formSubmit: function (e) {
    wx.request({
      url: "http://localhost:52631/api/Collect/AddCarDetails", //仅为示例，并非真实的接口地址
      method: 'get',
      data: e.detail.value,
      header: {
        'content-type': 'application/x-www-form-urlencoded' // 默认值
      },
      success: (res) => {
        //console.log(res.data)
        if (res.error) {
          wx.showToast({
            title: res.data.msg,
            icon: 'none',
            duration: 2000
          })
        } else {
          wx.showToast({
            title: '添加成功',
            icon: 'success',
            duration: 2000
          })
        }
      }
    })
  },



  handleSubmit: function () {
    
  },



  upload: function () {
    let that = this;
    wx.chooseImage({
      count: 9, // 默认9
      sizeType: ['original', 'compressed'], // 可以指定是原图还是压缩图，默认二者都有
      sourceType: ['album', 'camera'], // 可以指定来源是相册还是相机，默认二者都有
      success: res => {
        wx.showToast({
          title: '正在上传...',
          icon: 'loading',
          mask: true,
          duration: 1000
        })
        // 返回选定照片的本地文件路径列表，tempFilePath可以作为img标签的src属性显示图片
        let tempFilePaths = res.tempFilePaths;
        that.setData({
          tempFilePaths: tempFilePaths
        })

      }
    })
  },


  upload: function () {
    let that = this;
    wx.chooseImage({
      count: 9, // 默认9
      sizeType: ['original', 'compressed'], // 可以指定是原图还是压缩图，默认二者都有
      sourceType: ['album', 'camera'], // 可以指定来源是相册还是相机，默认二者都有
      success: res => {
        wx.showToast({
          title: '正在上传...',
          icon: 'loading',
          mask: true,
          duration: 1000
        })
        // 返回选定照片的本地文件路径列表，tempFilePath可以作为img标签的src属性显示图片
        let tempFilePaths = res.tempFilePaths;

        that.setData({
          tempFilePaths: tempFilePaths
        })
        /**
         * 上传完成后把文件上传到服务器
         */
        var count = 0;
        for (var i = 0, h = tempFilePaths.length; i < h; i++) {
          //上传文件
          /*  wx.uploadFile({
              url: HOST + '地址路径',
              filePath: tempFilePaths[i],
              name: 'uploadfile_ant',
              header: {
                "Content-Type": "multipart/form-data"
              },
              success: function (res) {
                count++;
                //如果是最后一张,则隐藏等待中  
                if (count == tempFilePaths.length) {
                  wx.hideToast();
                }
              },
              fail: function (res) {
                wx.hideToast();
                wx.showModal({
                  title: '错误提示',
                  content: '上传图片失败',
                  showCancel: false,
                  success: function (res) { }
                })
              }
            });*/
        }

      }
    })
  },


  listenerButtonPreviewImage: function (e) {
    let index = e.target.dataset.index;//预览图片的编号
    let that = this;
    wx.previewImage({
      current: that.data.tempFilePaths[index],//预览图片链接
      urls: that.data.tempFilePaths,//图片预览list列表
      success: function (res) {
        //console.log(res);
      },
      fail: function () {
        //console.log('fail')
      }
    })
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