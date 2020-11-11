// pages/demo04/demo04.js
Page({

  /**
   * 页面的初始数据
   */
  data: {
    num:0
  },
  //输入框的input事件的执行逻辑
  handInput(e){
    // console.log(e);
    this.setData({
      num:e.detail.value
    })
  },
  //加 减按钮的事件
  handtap(e){
    // console.log(e);
    //1 获取自定义属性opretion
    const opretion=e.currentTarget.dataset.opretion;
    this.setData({
      num:this.data.num+opretion
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