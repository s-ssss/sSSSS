{

/*-----------------------JAR包接口-----------------------*/

//壁纸"wallpaper":"http://maoyingshi.cc/api.php",
"wallpaper":"https://qiu.moe/a723",

//接口"spider":"https://gitee.com/liugd1005/tvbox/raw/master/jar/HOMESPIDERS.jar",

"spider":"https://notabug.org/ZID/SL/raw/main/IPTV/HOMESPIDERS.jar",



//电视直播源
//方法1
//"lives":[{"name":"live","type":0,"url":"http://111.67.196.181/mtv/zhibo.txt"}],


//方法2
"lives":[{"group":"redirect","channels":[{"name":"live","urls":[

//♥本地直播源地址

////电视直播 →自定义本地直播地址 =txt&ext=  需要转换成Base64编码 clan://TVBox/live.txt 

//"proxy://do=live&type=txt&ext=Y2xhbjovL1RWQm94L2xpdmUudHh0"
                                           
//♥网络直播源

"proxy://do=live&type=txt&ext=aHR0cHM6Ly9ub3RhYnVnLm9yZy9aSUQvU0wvcmF3L21haW4vSVBUVi9pcHR2LnR4dA=="


]}]}],
//方法2结束



"sites":[

{"key":"js豆瓣","name":"🐼┃豆瓣┃荐片","type":3,"api":"http://id.ganggang.live:63/js/drpy.min.js","ext":"http://id.ganggang.live:63/js/js_drpy.js","searchable": 0,"quickSearch": 0,"filterable": 0},

{"key":"快看","name":"👀┃快看┃影视","type":3,"api":"csp_Kuaikan","searchable":1,"quickSearch":1,"filterable":1},

{"key":"小苹果","name":"🍎┃苹果┃影视","type":3,"api":"csp_LiteApple","searchable":1,"quickSearch":1,"filterable":1},

//{"key":"drpy_js_蚂蚁影视","name":"🐜┃蚂蚁┃影视","type":3,"api":"https://gitee.com/wdc558/TVBox/raw/master/libs/drpy.min.js"},

{
"key":"LIBVIO",
"name":"🍒┃荔波┃影视",
"type":3,
"api":"csp_XPathMacFilter",
"searchable":1,
"quickSearch":1,
"filterable":1,
"ext":"https://gitee.com/liugd1005/tvbox/raw/master/XPath/LIBVIO.json"
},




{
"key":"csp_XYQHiker_饭团影视",
"name":"🍙┃饭团┃影视",
"type":3,
"api":"csp_XYQHiker",
"searchable":1,
"quickSearch":1,
"filterable":1,
"ext": "https://gitee.com/liugd1005/tvbox/raw/master/XYQHiker/ftys.json",
"jar":"https://gitee.com/liugd1005/tvbox/raw/master/jar/homespiders-xpath.jar"
},







{"key":"诺讯影视","name":" 🥃┃诺讯┃影视","type":3,"api":"csp_XPathMacFilter","searchable":1,"quickSearch":1,"filterable":1,"ext":"https://gitee.com/liugd1005/tvbox/raw/master/XPath/NXYS.json"},


{"key":"drpy_js_厂长资源","name":" 🏭┃厂长┃资源","type":3,"api":"https://gitee.com/maoshuiwei/tvbox/raw/master/drpy/lib/drpy2.min.js","ext":"https://gitee.com/maoshuiwei/tvbox/raw/master/drpy/js/厂长资源.js"},

{"key":"YQK_spider","name":"🏃┃一起┃电视","api":"csp_YQKAPP","type":3,"filterable":1,"playerType":2,"quickSearch":1,"searchable":1,"ext":"https://api-tx.shumaxc.xyz","jar":"http://我不是.肥猫.love:63/Jar/qq2.jar;md5;4E872E4AA2D4F8B6F4FFBC11E6B3E1A1"},

{"key":"csp_Kunyu77","name":"🌤┃酷云┃七七","type":3,"api":"csp_Kunyu77","searchable":1,"quickSearch":1,"filterable":1},

{"key":"布蕾蓝光","name":" 🍩┃布蕾┃蓝光","type":3,"api":"csp_XYQHiker","searchable":1,"quickSearch":1,"filterable":1,"ext": "https://gitee.com/liugd1005/tvbox/raw/master/XYQHiker/bllg.json","jar":"https://gitee.com/liugd1005/tvbox/raw/master/jar/homespiders-xpath.jar"},

{"key":"csp_XYQHiker_双十电影","name":" ❤️┃双十┃电影","type":3,"api":"csp_XYQHiker","searchable":1,"quickSearch":1,"filterable":1,"ext":"https://gitee.com/liugd1005/tvbox/raw/master/XYQHiker/1010dy.json","jar":"https://gitee.com/liugd1005/tvbox/raw/master/jar/homespiders-xpath.jar"},

{"key": "csp_XYQHiker_皮皮鸭影视", "name": "🐩┃皮皮┃影视", "type": 3, "api": "csp_XYQHiker", "searchable": 1, "quickSearch": 1, "filterable": 1, "ext": "https://gitee.com/liugd1005/tvbox/raw/master/XYQHiker/ppyys.json", "jar":"https://gitee.com/liugd1005/tvbox/raw/master/jar/homespiders-xpath.jar" },

{"key":"csp_XYQHiker_FREEOK", "name":"🎠┃Free┃影视", "type":3, "api":"csp_XYQHiker", "searchable":1, "quickSearch":1, "filterable":1, "ext": "https://gitee.com/liugd1005/tvbox/raw/master/XYQHiker/FREEOK.json", "jar":"https://gitee.com/liugd1005/tvbox/raw/master/jar/homespiders-xpath.jar" },

{"key":"360_spider","name":"📺┃360+┃影视","api":"csp_SP360","type":3,"filterable":1,"quickSearch":1,"searchable":1,"ext":""},

    {
      "key": "csp_XBPQ_6080",
      "name": "6080电影(XBPQ)",
      "type": 3,
      "api": "csp_XBPQ",
      "searchable": 1,
      "quickSearch": 1,
      "filterable": 0,
      "ext":{
        "请求头": "手机",
        "起始页": "1",
        "二次截取": "<div class=\"module-list\">&&<div class=\"mx-lrmenu\">[替换:<div class=\"fixed_right_bar\">>><div class=\"module-item\">]||首页--最新热播&&<div  class=\"module-main\"[替换:<div class=\"module module-wrapper\">>><div class=\"module-item\">]",
        "数组": "<div class=\"module-item-pic\">&&<div class=\"module-item\">[不包含:理论片]",
        "副标题": "class=\"module-item-text\"&&<",
        "线路数组": "class=\"module-tab-item tab-item\"&&</div>[排序:极速播放>在线观看]",
        "线路标题": "<span>&&</small>[替换:</span>>>（更至]+集）",
        "影片年代": "<a class=\"tag-link\"*>&&</a>",
        "导演": "导演：</span>&&</a>",
        "演员": "主演：</span>&&</div>",
        "简介": "剧情：</span>&&</span>",
        "播放数组": "<div class=\"sort-item\"&&</div>",
        "播放列表": "<!--&&-->",
        "免嗅": "1",
        "嗅探词": ".m3u8#.mp4",
        "过滤词": ".html#url=http",
        "搜索模式": "0",
        "搜索链接前缀": "/video/",
        "搜索链接后缀": ".html",
        "分类url": "https://www.6080dy1.com/vodshow/{cateId}-{area}-{by}-{class}-----{catePg}---{year}.html",
        "分类": "电影&电视剧&综艺&动漫",
        "分类值": "1&2&3&4",
        "类型": "动作片&喜剧片&爱情片&科幻片&恐怖片&剧情片&战争片&纪录片&悬疑片&犯罪片&冒险片&动画片&惊悚片&奇幻片国产剧&欧美剧&日韩剧&港台剧&泰剧&海外剧大陆综艺&日韩综艺&港台综艺&欧美综艺&演唱会||国产动漫&日韩动漫&欧美动漫&港台动漫",
        "类型值": "25&26&27&28&30&31&33&35&36&38&40&41&43&4442&45&47&49&51&5220&21&22&23&24||29&32&34&37",
        "剧情": "喜剧&爱情&恐怖&动作&科幻&剧情&战争&警匪&犯罪&动画&奇幻&武侠&冒险&枪战&恐怖&悬疑&惊悚&经典&青春&文艺&微电影&古装&历史&运动&农村&儿童&网络电影古装&战争&青春偶像&喜剧&家庭&犯罪&动作&奇幻&剧情&历史&经典&乡村&情景&商战&网剧&其他选秀&情感&访谈&播报&旅游&音乐&美食&纪实&曲艺&生活&游戏互动&财经&求职||情感&科幻&热血&推理&搞笑&冒险&萝莉&校园&动作&机战&运动&战争&少年&少女&社会&原创&亲子&益智&励志&其他",
        "剧情值": "*",
        "地区": "大陆&香港&台湾&美国&法国&英国&日本&韩国&德国&泰国&印度&意大利&西班牙&加拿大&其他内地&韩国&香港&台湾&日本&美国&泰国&英国&新加坡&其他内地&港台&日韩&欧美||国产&日本&欧美&其他",
        "筛选": "1"
      }
    },

//BILIBILI

{"key": "MV","name": "🎤MV","type": 3,"api": "csp_Bili","searchable": 0,"quickSearch": 0,"filterable": 1,"ext": "https://gitee.com/zhahaoyi/tvbox/raw/master/bilbili/%E5%90%BE%E7%88%B1MTV.json","spider":"https://gitee.com/zhahaoyi/tvbox/raw/master/jar/0723.jar;md5;c5c337bb2793598e9aa5953898fbb087"},

{"key": "学堂","name": "🍉学堂","type": 3,"api": "csp_Bili","searchable":0,"quickSearch": 0,"filterable": 1,"ext": "https://gitee.com/zhahaoyi/tvbox/raw/master/bilbili/%E5%90%BE%E7%88%B1%E5%AD%A6%E5%A0%82.json","spider":"https://gitee.com/zhahaoyi/tvbox/raw/master/jar/0723.jar;md5;c5c337bb2793598e9aa5953898fbb087"},

{"key": "EXCEL","name": "🌈Excel","type": 3,"api": "csp_Bili","searchable": 0,"quickSearch": 0,"filterable": 1,"ext": "https://gitee.com/zhahaoyi/tvbox/raw/master/bilbili/%E5%90%BE%E7%88%B1Excel%E6%95%99%E7%A8%8B.json","spider":"https://gitee.com/zhahaoyi/tvbox/raw/master/jar/0723.jar;md5;c5c337bb2793598e9aa5953898fbb087"},

{"key": "演唱会","name": "🌈演唱会","type": 3,"api": "csp_Bili","searchable": 0,"quickSearch": 0,"filterable": 1,"ext": "https://gitee.com/zhahaoyi/tvbox/raw/master/bilbili/%E5%90%BE%E7%88%B1%E6%BC%94%E5%94%B1%E4%BC%9A.json","spider":"https://gitee.com/zhahaoyi/tvbox/raw/master/jar/0723.jar;md5;c5c337bb2793598e9aa5953898fbb087"},

{"key":"csp_Bili热舞","name":"💃女团热舞","type":3,"api":"csp_Bili","searchable":0,"quickSearch":0,"filterable":1,"ext":"https://gitee.com/zhahaoyi/tvbox/raw/master/json/女团.txt"},

{"key":"csp_Bili相声","name":"🏮相声小品","type":3,"api":"csp_Bili","searchable":0,"quickSearch":0,"filterable":1,"ext":"https://gitee.com/zhahaoyi/tvbox/raw/master/json/相声.txt"},

{"key":"csp_Bili戏曲","name":"🎈国粹戏曲","type":3,"api":"csp_Bili","searchable":0,"quickSearch":0,"filterable":1,"ext":"https://gitee.com/zhahaoyi/tvbox/raw/master/json/戏曲.txt"}




//★👆上面结尾要少一个,号不然会抱错


],








//解析接口

//解X设置
"parses": [{
		"name": "Json聚合",
		"type": 3,
		"url": "Demo"
	}, {
		"name": "Web聚合",
		"type": 3,
		"url": "Web"
	}, {
		"name": "rx2",
		"type": 1,
		"url": "http://rxjx.kuanjv.com/allm3u8.php?url="
	}, {
		"name": "星辰云",
		"type": 1,
		"url": "https://json.xn--9kq078cdn3a.cc/api/?key=GMp1H9mKRKVriBulRT&url=",
		"header": {
			"User-Agent": "Mozilla/5.0"
		}   
	}, {
		"name": "万年魂环",
		"type": 1,
		"url": "https://jiexi.parses.repl.co/api.php?url="
	}, {
		"name": "刚刚走过",
		"type": 1,
		"url": "http://jx.fuqizhishi.com:63/API.php?appkey=feimao&url="
	}, {
		"name": "bozrc",
		"type": 0,
		"url": "https://jx.bozrc.com:4433/player/?url=",
		"ext": {
			"flag": ["qq","腾讯","企鹅","IQiYi","qiyi","爱奇艺","奇艺","youku","YouKu","优酷","sohu","SoHu","搜狐","letv","LeShi","乐视","mgtv","MangGuo","芒果","CL4K","renrenmi","ltnb","bilibili","1905","xigua"]
		}    
	}, {
		"name": "bulei",
		"type": 0,
		"url": "https://bf.bulei.cc/player/?url=",
		"header": {
			"User-Agent": "Mozilla/5.0"
		} 
	}, {
		"name": "未知",
		"type": 0,
		"url": "https://h5.freejson.xyz/player/?url=",
		"ext": {
			"flag": ["qq", "腾讯", "qiyi", "爱奇艺", "奇艺", "youku", "优酷", "mgtv", "芒果", "letv", "乐视", "pptv", "PPTV", "sohu", "bilibili", "哔哩哔哩", "哔哩"],"header":{"User-Agent":"okhttp/4.1.0"}
		}    
	}, {
		"name": "OKjx嗅探",
		"type": 0,
		"url": "https://okjx.cc/?url="
	}],
    "rules": [
    {"host": "*","rule": ["default.365yg.com"]},
    {"host": "dyxs20.com","rule": [".m3u8"]},
    {"host": "www.agemys.cc","rule": ["cdn-tos","obj/tos-cn"]},
    {"host": "www.sharenice.net","rule": ["http.*?/play.{0,3}\\?[^url]{2,8}=.*"]},
    {"host": "www.sharenice.net","rule": ["qianpailive.com","vid="]},
    {"host": "*","rule": ["douyin.com/aweme","video_id="]},
    {"host": "*","rule": ["huoshan.com","/item/video/"]},
    {"host": "*","rule": ["http((?!http).){12,}?\\.(m3u8|mp4|flv|avi|mkv|rm|wmv|mpg|m4a)\\?.*"]},
    {"host": "*","rule": ["http((?!http).){12,}\\.(m3u8|mp4|flv|avi|mkv|rm|wmv|mpg|m4a)"]}],
   "flags":["youku","qq","QQ","iqiyi","qiyi","letv","sohu","tudou","pptv","PPTV","mgtv","ltnb","rx","CL4K","xfyun","wuduzy","wasu","bilibili","renrenmi","xmm","xigua","m1905 ","funshion ","优酷","芒果","腾讯","爱奇艺","奇艺","哔哩哔哩","哔哩"],


"ijk":[{"group":"软解码","options":[{"category":4,"name":"opensles","value":"0"},

{"category":4,"name":"overlay-format","value":"842225234"},

{"category":4,"name":"framedrop","value":"1"},

{"category":4,"name":"soundtouch","value":"1"},

{"category":4,"name":"start-on-prepared","value":"1"},

{"category":1,"name":"http-detect-range-support","value":"0"},

{"category":1,"name":"fflags","value":"fastseek"},

{"category":2,"name":"skip_loop_filter","value":"48"},

{"category":4,"name":"reconnect","value":"1"},

{"category":4,"name":"enable-accurate-seek","value":"0"},

{"category":4,"name":"mediacodec","value":"0"},

{"category":4,"name":"mediacodec-auto-rotate","value":"0"},

{"category":4,"name":"mediacodec-handle-resolution-change","value":"0"},

{"category":4,"name":"mediacodec-hevc","value":"0"},

{"category":1,"name":"dns_cache_timeout","value":"600000000"}]},{"group":"硬解码","options":[{"category":4,"name":"opensles","value":"0"},

{"category":4,"name":"overlay-format","value":"842225234"},

{"category":4,"name":"framedrop","value":"1"},

{"category":4,"name":"soundtouch","value":"1"},

{"category":4,"name":"start-on-prepared","value":"1"},

{"category":1,"name":"http-detect-range-support","value":"0"},

{"category":1,"name":"fflags","value":"fastseek"},

{"category":2,"name":"skip_loop_filter","value":"48"},

{"category":4,"name":"reconnect","value":"1"},

{"category":4,"name":"enable-accurate-seek","value":"0"},

{"category":4,"name":"mediacodec","value":"1"},

{"category":4,"name":"mediacodec-auto-rotate","value":"1"},

{"category":4,"name":"mediacodec-handle-resolution-change","value":"1"},

{"category":4,"name":"mediacodec-hevc","value":"1"},

{"category":1,"name":"dns_cache_timeout","value":"600000000"}
]}
],


//广告

"ads":["mimg.0c1q0l.cn",
"www.googletagmanager.com",
"www.google-analytics.com",
"mc.usihnbcq.cn",
"mg.g1mm3d.cn",
"mscs.svaeuzh.cn",
"cnzz.hhttm.top",
"tp.vinuxhome.com",
"cnzz.mmstat.com",
"www.baihuillq.com",
"s23.cnzz.com",
"z3.cnzz.com",
"c.cnzz.com",
"stj.v1vo.top",
"z12.cnzz.com",
"img.mosflower.cn",
"tips.gamevvip.com",
"ehwe.yhdtns.com",
"xdn.cqqc3.com",
"www.jixunkyy.cn",
"sp.chemacid.cn",
"hm.baidu.com",
"s9.cnzz.com",
"z6.cnzz.com",
"um.cavuc.com",
"mav.mavuz.com",
"wofwk.aoidf3.com",
"z5.cnzz.com",
"xc.hubeijieshikj.cn",
"tj.tianwenhu.com",
"xg.gars57.cn",
"k.jinxiuzhilv.com",
"cdn.bootcss.com",
"ppl.xunzhuo123.com",
"xomk.jiangjunmh.top",
"img.xunzhuo123.com",
"z1.cnzz.com",
"s13.cnzz.com",
"xg.huataisangao.cn",
"z7.cnzz.com",
"xg.huataisangao.cn",
"z2.cnzz.com",
"s96.cnzz.com",
"q11.cnzz.com",
"thy.dacedsfa.cn",
"xg.whsbpw.cn",
"s19.cnzz.com",
"z8.cnzz.com",
"s4.cnzz.com",
"f5w.as12df.top",
"ae01.alicdn.com",
"www.92424.cn",
"k.wudejia.com",
"vivovip.mmszxc.top",
"qiu.xixiqiu.com",
"cdnjs.hnfenxun.com",
"cms.qdwght.com"]}