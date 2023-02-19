{

/*-----------------------JAR包接口-----------------------*/

//壁纸"wallpaper":"http://maoyingshi.cc/api.php",
"wallpaper":"https://qiu.moe/a723",

//接口"spider":"https://gitee.com/liugd1005/tvbox/raw/master/jar/HOMESPIDERS.jar",

"spider":"https://gitee.com/as5555/sss/raw/s/Yoursmile.jar",



//电视直播源
//方法1
//"lives":[{"name":"live","type":0,"url":"http://111.67.196.181/mtv/zhibo.txt"}],


//方法2
"lives":[{"group":"redirect","channels":[{"name":"live","urls":[

//♥本地直播源地址

////电视直播 →自定义本地直播地址 =txt&ext=  需要转换成Base64编码 clan://TVBox/live.txt

//"proxy://do=live&type=txt&ext=（Y2xhbjovL1RWQm94L2xpdmUudHh0）←替换↓"

//♥网络直播源

"proxy://do=live&type=txt&ext=aHR0cHM6Ly9ub3RhYnVnLm9yZy9aSUQvU0wvcmF3L21haW4vSVBUVi9pcHR2LnR4dA=="


]}]}],
//方法2结束



"sites":[

//推荐首页

{"key":"js豆瓣","name":"🐼┃豆瓣┃荐片","type":3,"api":"http://id.ganggang.live:63/js/drpy.min.js","ext":"http://id.ganggang.live:63/js/js_drpy.js","searchable": 0,"quickSearch": 0,"filterable": 0},




//测试


{"key":"csp_Czsapp","name":"🏭厂长","type":3,"api":"csp_Czsapp","searchable":1,"quickSearch":1,"filterable":1},
{"key":"csp_YQKAPP","name":"🌎一起看","type":3,"api":"csp_YQKAPP","playerType":2,"searchable":1,"quickSearch":1,"filterable":1,"ext":"https://api-tx.shumaxc.xyz"},
{"key":"csp_Yht","name":"🍀野荷塘","type":3,"api":"csp_Yht","searchable":1,"quickSearch":1,"filterable":1,"ext":"https://yehetang.cc"},





//测试中
{ "key": "csp_XYQHiker_兰花影视", "name": "🌼┃兰花┃测试", "type": 3, "api": "csp_XYQHiker", "searchable": 1, "quickSearch": 1, "filterable": 1, "ext": "https://gitee.com/liugd1005/home-tvbox/raw/master/TVBOX-XYQHiker/lhys.json", "jar": "https://gitee.com/liugd1005/home-tvbox/raw/master/Home-Spiders/homespiders-xpath.jar" },

{ "key": "csp_XYQHiker_慢大浪影视", "name": "⛲┃大浪┃测试", "type": 3, "api": "csp_XYQHiker", "searchable": 1, "quickSearch": 1, "filterable": 1, "ext": "https://gitee.com/liugd1005/home-tvbox/raw/master/TVBOX-XYQHiker/mdlys.json", "jar": "https://gitee.com/liugd1005/home-tvbox/raw/master/Home-Spiders/homespiders-xpath.jar" },


//优质

{"key":"AppTT","name":"🐰┃图图┃影视","type":"3","api":"csp_Dora","searchable":"1","quickSearch":"1","filterable":"1","ext":"110c922de7d69804467fb83d3bb664b5","jar":"https://gitee.com/as5555/sss/raw/jar/ts.jar"},

{"key":"快看","name":"👀┃快看┃影视","type":3,"api":"csp_Kuaikan","searchable":1,"quickSearch":1,"filterable":1},

{"key":"小苹果","name":"🍎┃苹果┃影视","type":3,"api":"csp_LiteApple","searchable":1,"quickSearch":1,"filterable":1},

{"key":"csp_Bd","name":"🚀┃哔嘀┃影视","type":3,"api":"csp_Bdys01","searchable":1,"quickSearch":1,"filterable":1},

{"key":"csp_555","name":"🍭┃555┃影视","type":3,"api":"csp_Dy555","searchable":1,"quickSearch":1,"filterable":1},

{"key":"csp_Bttoo","name":"✌┃俩个┃BTT","type":3,"api":"csp_Bttoo","searchable":1,"quickSearch":1,"filterable":1},

{"key":"csp_Auete","name":"🚤┃奥特┃影视","type":3,"api":"csp_Auete","searchable":1,"quickSearch":1,"filterable":1},

{"key":"SP360","name":"💘┃360┃影视","type":3,"api":"csp_SP360","searchable":1,"quickSearch":1,"filterable":1},

{ "key": "Lezhu_spider", "name": "🐷┃乐猪┃影视", "api": "csp_Lezhu", "type": 3, "filterable": 1, "playerType": 2, "quickSearch": 1, "searchable": 1, "ext": "" },

{"key":"csp_Kunyu77","name":" 🏳️‍🌈┃酷云┃七七","type":3,"api":"csp_Kunyu77","searchable":1,"quickSearch":1,"filterable":1},

{ "key":"LIBVIO", "name":"🍒┃荔波┃影视", "type":3, "api":"csp_XPathMacFilter", "searchable":1, "quickSearch":1, "filterable":1, "ext":"https://gitee.com/liugd1005/tvbox/raw/master/XPath/LIBVIO.json" },

{ "key":"csp_XYQHiker_饭团影视", "name":"🍙┃饭团┃影视", "type":3, "api":"csp_XYQHiker", "searchable":1, "quickSearch":1, "filterable":1, "ext": "https://gitee.com/liugd1005/tvbox/raw/master/XYQHiker/ftys.json", "jar":"https://gitee.com/liugd1005/tvbox/raw/master/jar/homespiders-xpath.jar" },

{"key":"drpy_js_喵喵影院","name":"🐱┃喵喵┃影院","type":3,"api":"https://gitcode.net/qq_32394351/dr_py/-/raw/master/libs/drpy2.min.js","ext":"https://gitcode.net/qq_32394351/dr_py/-/raw/master/js/喵喵.js"},

{"key":"诺讯影视","name":"🌍┃诺讯┃影视","type":3,"api":"csp_XPathMacFilter","searchable":1,"quickSearch":1,"filterable":1,"ext":"https://gitee.com/liugd1005/tvbox/raw/master/XPath/NXYS.json"},

{"key":"drpy_js_厂长资源","name":" 🏭┃厂长┃资源","type":3,"api":"https://gitee.com/as5555/sss/raw/s/CZZY","searchable":1, "quickSearch":1, "filterable":1},

{"key":"YQK_spider","name":"🏃┃一起┃电视","api":"csp_YQKAPP","type":3,"filterable":1,"playerType":2,"quickSearch":1,"searchable":1,"ext":"https://api-tx.shumaxc.xyz","jar":"http://我不是.肥猫.love:63/Jar/qq2.jar;md5;4E872E4AA2D4F8B6F4FFBC11E6B3E1A1"},

{"key":"布蕾蓝光","name":" 🍩┃布蕾┃蓝光","type":3,"api":"csp_XYQHiker","searchable":1,"quickSearch":1,"filterable":1,"ext": "https://gitee.com/liugd1005/tvbox/raw/master/XYQHiker/bllg.json","jar":"https://gitee.com/liugd1005/tvbox/raw/master/jar/homespiders-xpath.jar"},

{"key":"csp_XYQHiker_双十电影","name":"🎯┃双十┃电影","type":3,"api":"csp_XYQHiker","searchable":1,"quickSearch":1,"filterable":1,"ext":"https://gitee.com/liugd1005/tvbox/raw/master/XYQHiker/1010dy.json","jar":"https://gitee.com/liugd1005/tvbox/raw/master/jar/homespiders-xpath.jar"},

{"key": "csp_XYQHiker_皮皮鸭影视", "name": "🐩┃皮皮┃影视", "type": 3, "api": "csp_XYQHiker", "searchable": 1, "quickSearch": 1, "filterable": 1, "ext": "https://gitee.com/liugd1005/tvbox/raw/master/XYQHiker/ppyys.json", "jar":"https://gitee.com/liugd1005/tvbox/raw/master/jar/homespiders-xpath.jar" },

{"key":"csp_XYQHiker_FREEOK", "name":"🎠┃Free┃影视", "type":3, "api":"csp_XYQHiker", "searchable":1, "quickSearch":1, "filterable":1, "ext": "https://gitee.com/liugd1005/tvbox/raw/master/XYQHiker/FREEOK.json", "jar":"https://gitee.com/liugd1005/tvbox/raw/master/jar/homespiders-xpath.jar" },

{ "key": "csp_新视觉", "name": "✨┃NEW┃视觉", "type": 3, "api": "csp_Xinsj", "searchable": 1, "quickSearch": 1, "filterable": 1, "jar":"http://101.34.67.237/files/新视觉.jar" },

{ "key": "dr_菜狗", "name": " 🐕┃菜狗┃采集", "type": 3, "api": "http://101.34.67.237/libs/drpy.min.js", "searchable": 2, "quickSearch": 0, "filterable": 1, "ext": "http://101.34.67.237/js/菜狗.js" },

{ "key": "dr_真不卡", "name": "💳┃不卡┃影视", "type": 3, "api": "http://101.34.67.237/libs/drpy.min.js", "searchable": 2, "quickSearch": 0, "filterable": 0, "ext": "http://101.34.67.237/js/真不卡.js" },

{"key":"drpy_js_子子影视","name":"🍆┃子子┃影视","type":3,"api":"https://drpy.netlify.app/libs/drpy2.min.js","ext":"https://cx66.tk/jshk/jsv/子子影视.js"},

{"key":"csp_Lgyy","name":"🌀┃蓝光┃影院","type":3,"api":"csp_Lgyy","searchable":1,"quickSearch":1,"filterable":1,"ext":"https://www.lgyy.tv"},


{"key":"csp_Nmys","name":"👨‍🌾┃农民┃影视","type":3,"api":"csp_Nmys","searchable":1,"quickSearch":1,"filterable":1,"ext":"https://agit.ai/Yoursmile7/TVBox/raw/branch/master/sub/Nmys.json"},

//云盘

{"key":"Gitcafe","name":"纸条","type":"3","api":"csp_Paper","searchable":"1","quickSearch":"1","filterable":"1","ext":"https://agit.ai/Yoursmile7/TVBox/raw/branch/master/token.txt"},
{"key":"Upso","name":"云搜","type":"3","api":"csp_UpYun","searchable":"1","quickSearch":"1","filterable":"1","ext":"https://agit.ai/Yoursmile7/TVBox/raw/branch/master/token.txt"},
{"key":"Zhaozy","name":"资源","type":"3","api":"csp_Zhaozy","searchable":"1","quickSearch":"1","filterable":"1","ext":"https://agit.ai/Yoursmile7/TVBox/raw/branch/master/token.txt$$$yingshi$$$abcd1234"},
{ "key": "找资源", "name": "找资源", "type": 3, "api": "csp_Zhaozy", "searchable": 1, "playerType": 1, "quickSearch": 1, "filterable": 1 },






//BILIBILI

{"key": "MV","name": "🌌MTV","type": 3,"api": "csp_Bili","searchable": 0,"quickSearch": 0,"filterable": 1,"ext": "https://gitee.com/zhahaoyi/tvbox/raw/master/bilbili/%E5%90%BE%E7%88%B1MTV.json","spider":"https://gitee.com/zhahaoyi/tvbox/raw/master/jar/0723.jar;md5;c5c337bb2793598e9aa5953898fbb087"},

{"key": "学堂","name": " 👩‍💻学堂","type": 3,"api": "csp_Bili","searchable":0,"quickSearch": 0,"filterable": 1,"ext": "https://gitee.com/zhahaoyi/tvbox/raw/master/bilbili/%E5%90%BE%E7%88%B1%E5%AD%A6%E5%A0%82.json","spider":"https://gitee.com/zhahaoyi/tvbox/raw/master/jar/0723.jar;md5;c5c337bb2793598e9aa5953898fbb087"},

{"key": "EXCEL","name": " 📊办公","type": 3,"api": "csp_Bili","searchable": 0,"quickSearch": 0,"filterable": 1,"ext": "https://gitee.com/zhahaoyi/tvbox/raw/master/bilbili/%E5%90%BE%E7%88%B1Excel%E6%95%99%E7%A8%8B.json","spider":"https://gitee.com/zhahaoyi/tvbox/raw/master/jar/0723.jar;md5;c5c337bb2793598e9aa5953898fbb087"},

{"key": "演唱会","name": " 🎧Concert","type": 3,"api": "csp_Bili","searchable": 0,"quickSearch": 0,"filterable": 1,"ext": "https://gitee.com/zhahaoyi/tvbox/raw/master/bilbili/%E5%90%BE%E7%88%B1%E6%BC%94%E5%94%B1%E4%BC%9A.json","spider":"https://gitee.com/zhahaoyi/tvbox/raw/master/jar/0723.jar;md5;c5c337bb2793598e9aa5953898fbb087"},

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