var that;
//创建一个tab类
class Tab{
    constructor(id){
        that=this;
        //querySelector:获取元素
        //获取元素
        this.main=document.querySelector(id);
        //获取大盒子里面的加号按钮
        this.add=this.main.querySelector('.tabadd');
        //获取li的父元素
        this.ul=this.main.querySelector('.fisrstnav ul:first-child');
        //获取section的父元素
        this.fsection=this.main.querySelector('.tabscon');
        //调用init初始化方法
        this.init();
    }

    //初始化方法
    init(){
        this.updateNode();
        //init初始化操作让相关的元素绑定事件
        for(var i=0;i<this.lis.length;i++){
            this.lis[i].index=i;
            this.lis[i].onclick=this.toggleTab;
            this.remove[i].onclick=this.removeTab;
            this.spans[i].ondblclick=this.editTab;
            this.sections[i].ondblclick=this.editTab;
        }
        //给按钮添加点击事件
        this.add.onclick=this.addTab;
    }

    //1.切换功能的方法
    toggleTab(){
        //调用清除类
        that.clearClass();
        // console.log(this.index);
        this.className='liactive';
        that.sections[this.index].className='conactive';
    }

    //2.添加功能的方法
    addTab(){
        var a=3;
        //调用清除类
        that.clearClass();
        //1、创建li远古三和section元素。
        var li='<li class="liactive"><span>测试'+(++a)+'</span><span class="icon_guanbi">x</span></li>';
        //创建section
        var section='<section class="conactive">测试1</section>';

        //2、把这两个元素追加到对应的父元素里面。
        that.ul.insertAdjacentHTML('beforeend',li);
        that.fsection.insertAdjacentHTML('beforeend',section);
        that.init();
    }

    //3.删除功能的方法
    removeTab(e){
        e.stopPropagation();//阻止冒泡，放置触发li的切换点击事件
        var index=this.parentNode.index;
        console.log(index);
        //根据索引号删除对应的li，和section
        //remove()：直接移除元素
        that.lis[index].remove();
        that.sections[index].remove();
        that.init();
        //当我们删除的不是选中状态的li的时候，原来的选中状态li保持不变
        if(document.querySelector('.liactive')){
            return;
        }
        //当我们删除了选中状态的这个li的时候，让它的前一个li处于选定状态 
        index--;
        //给减减后的页手动添加点击事件
        //手动调用我们的点击事件，不需要鼠标触发
        //如果前面为真，就执行后面的，如果前面为假，就不去调用
        that.lis[index]&&that.lis[index].click();
    }

    //4.修改功能的方法
    editTab(){
        //获取原本的文字
        var str=this.innerHTML;
        //双击禁止选中文字
        window.getSelection?window.getSelection().removeAllRanges():document.getSelection.empty();
        //alert(1);
        //添加input文本框
        this.innerHTML='<input type="text"/>';
        var input=this.children[0];
        input.value=str;
        //文本框里面的文字处于选中状态
        input.select();
        //当我们离开文本框就把文本框里面的值给span
        input.onblur=function(){
            this.parentNode.innerHTML=this.value;
        }
        //按下回车也可以吧文本框里面的值给span
        input.onkeyup=function(e){
            if(e.keyCode===13){
                //手动调用表单失去焦点事件，不需要鼠标离开操作
                this.blur();
            }
        }
    }

    // 22

    //清除类
    clearClass(){
        for(var i=0;i<this.lis.length;i++){
            this.lis[i].className='';
            this.sections[i].className='';
        }
    }

    //因为我们动态添加元素，需要从新的获取对应的元素
    updateNode(){
        //获取大盒子里面的所有的li
        this.lis=this.main.querySelectorAll('li');
        //获取大盒子里面的section
        this.sections=this.main.querySelectorAll('section');
        //获取所有的所有的删除按钮
        this.remove=this.main.querySelectorAll('.icon_guanbi');
        //获取页面所有的span
        this.spans=this.main.querySelectorAll('.fisrstnav li span:first-child');
    }
}
//实例化tab类
new Tab('#tab');