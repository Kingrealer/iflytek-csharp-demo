using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace tts
{
    public enum MSP_ERROR {
        MSP_SUCCESS = 0,
        MSP_ERROR_FAIL = -1,
        MSP_ERROR_EXCEPTION = -2,

        /* General errors 10100(0x2774) */
        MSP_ERROR_GENERAL = 10100, 	/* 0x2774 */
        MSP_ERROR_OUT_OF_MEMORY = 10101, 	/* 0x2775 */
        MSP_ERROR_FILE_NOT_FOUND = 10102, 	/* 0x2776 */
        MSP_ERROR_NOT_SUPPORT = 10103, 	/* 0x2777 */
        MSP_ERROR_NOT_IMPLEMENT = 10104, 	/* 0x2778 */
        MSP_ERROR_ACCESS = 10105, 	/* 0x2779 */
        MSP_ERROR_INVALID_PARA = 10106, 	/* 0x277A */
        MSP_ERROR_INVALID_PARA_VALUE = 10107, 	/* 0x277B */
        MSP_ERROR_INVALID_HANDLE = 10108, 	/* 0x277C */
        MSP_ERROR_INVALID_DATA = 10109, 	/* 0x277D */
        MSP_ERROR_NO_LICENSE = 10110, 	/* 0x277E */
        MSP_ERROR_NOT_INIT = 10111, 	/* 0x277F */
        MSP_ERROR_NULL_HANDLE = 10112, 	/* 0x2780 */
        MSP_ERROR_OVERFLOW = 10113, 	/* 0x2781 */
        MSP_ERROR_TIME_OUT = 10114, 	/* 0x2782 */
        MSP_ERROR_OPEN_FILE = 10115, 	/* 0x2783 */
        MSP_ERROR_NOT_FOUND = 10116, 	/* 0x2784 */
        MSP_ERROR_NO_ENOUGH_BUFFER = 10117, 	/* 0x2785 */
        MSP_ERROR_NO_DATA = 10118, 	/* 0x2786 */
        MSP_ERROR_NO_MORE_DATA = 10119, 	/* 0x2787 */
        MSP_ERROR_NO_RESPONSE_DATA = 10120, 	/* 0x2788 */
        MSP_ERROR_ALREADY_EXIST = 10121, 	/* 0x2789 */
        MSP_ERROR_LOAD_MODULE = 10122, 	/* 0x278A */
        MSP_ERROR_BUSY = 10123, 	/* 0x278B */
        MSP_ERROR_INVALID_CONFIG = 10124, 	/* 0x278C */
        MSP_ERROR_VERSION_CHECK = 10125, 	/* 0x278D */
        MSP_ERROR_CANCELED = 10126, 	/* 0x278E */
        MSP_ERROR_INVALID_MEDIA_TYPE = 10127, 	/* 0x278F */
        MSP_ERROR_CONFIG_INITIALIZE = 10128, 	/* 0x2790 */
        MSP_ERROR_CREATE_HANDLE = 10129, 	/* 0x2791 */
        MSP_ERROR_CODING_LIB_NOT_LOAD = 10130, 	/* 0x2792 */
        MSP_ERROR_USER_CANCELLED = 10131, 	/* 0x2793 */
        MSP_ERROR_INVALID_OPERATION = 10132, 	/* 0x2794 */
        MSP_ERROR_MESSAGE_NOT_COMPLETE = 10133,	/* 0x2795 */  //flash

        /* Error codes of network 10200(0x27D8)*/
        MSP_ERROR_NET_GENERAL = 10200, 	/* 0x27D8 */
        MSP_ERROR_NET_OPENSOCK = 10201, 	/* 0x27D9 */   /* Open socket */
        MSP_ERROR_NET_CONNECTSOCK = 10202, 	/* 0x27DA */   /* Connect socket */
        MSP_ERROR_NET_ACCEPTSOCK = 10203, 	/* 0x27DB */   /* Accept socket */
        MSP_ERROR_NET_SENDSOCK = 10204, 	/* 0x27DC */   /* Send socket data */
        MSP_ERROR_NET_RECVSOCK = 10205, 	/* 0x27DD */   /* Recv socket data */
        MSP_ERROR_NET_INVALIDSOCK = 10206, 	/* 0x27DE */   /* Invalid socket handle */
        MSP_ERROR_NET_BADADDRESS = 10207, 	/* 0x27EF */   /* Bad network address */
        MSP_ERROR_NET_BINDSEQUENCE = 10208, 	/* 0x27E0 */   /* Bind after listen/connect */
        MSP_ERROR_NET_NOTOPENSOCK = 10209, 	/* 0x27E1 */   /* Socket is not opened */
        MSP_ERROR_NET_NOTBIND = 10210, 	/* 0x27E2 */   /* Socket is not bind to an address */
        MSP_ERROR_NET_NOTLISTEN = 10211, 	/* 0x27E3 */   /* Socket is not listening */
        MSP_ERROR_NET_CONNECTCLOSE = 10212, 	/* 0x27E4 */   /* The other side of connection is closed */
        MSP_ERROR_NET_NOTDGRAMSOCK = 10213, 	/* 0x27E5 */   /* The socket is not datagram type */
        MSP_ERROR_NET_DNS = 10214, 	/* 0x27E6 */   /* domain name is invalid or dns server does not function well */
        MSP_ERROR_NET_INIT = 10215, 	/* 0x27E7 */   /* ssl ctx create failed */

        /* Error codes of mssp message 10300(0x283C) */
        MSP_ERROR_MSG_GENERAL = 10300, 	/* 0x283C */
        MSP_ERROR_MSG_PARSE_ERROR = 10301, 	/* 0x283D */
        MSP_ERROR_MSG_BUILD_ERROR = 10302, 	/* 0x283E */
        MSP_ERROR_MSG_PARAM_ERROR = 10303, 	/* 0x283F */
        MSP_ERROR_MSG_CONTENT_EMPTY = 10304, 	/* 0x2840 */
        MSP_ERROR_MSG_INVALID_CONTENT_TYPE = 10305, 	/* 0x2841 */
        MSP_ERROR_MSG_INVALID_CONTENT_LENGTH = 10306, 	/* 0x2842 */
        MSP_ERROR_MSG_INVALID_CONTENT_ENCODE = 10307, 	/* 0x2843 */
        MSP_ERROR_MSG_INVALID_KEY = 10308, 	/* 0x2844 */
        MSP_ERROR_MSG_KEY_EMPTY = 10309, 	/* 0x2845 */
        MSP_ERROR_MSG_SESSION_ID_EMPTY = 10310, 	/* 0x2846 */
        MSP_ERROR_MSG_LOGIN_ID_EMPTY = 10311, 	/* 0x2847 */
        MSP_ERROR_MSG_SYNC_ID_EMPTY = 10312, 	/* 0x2848 */
        MSP_ERROR_MSG_APP_ID_EMPTY = 10313, 	/* 0x2849 */
        MSP_ERROR_MSG_EXTERN_ID_EMPTY = 10314, 	/* 0x284A */
        MSP_ERROR_MSG_INVALID_CMD = 10315, 	/* 0x284B */
        MSP_ERROR_MSG_INVALID_SUBJECT = 10316, 	/* 0x284C */
        MSP_ERROR_MSG_INVALID_VERSION = 10317, 	/* 0x284D */
        MSP_ERROR_MSG_NO_CMD = 10318, 	/* 0x284E */
        MSP_ERROR_MSG_NO_SUBJECT = 10319, 	/* 0x284F */
        MSP_ERROR_MSG_NO_VERSION = 10320, 	/* 0x2850 */
        MSP_ERROR_MSG_MSSP_EMPTY = 10321, 	/* 0x2851 */
        MSP_ERROR_MSG_NEW_RESPONSE = 10322, 	/* 0x2852 */
        MSP_ERROR_MSG_NEW_CONTENT = 10323, 	/* 0x2853 */
        MSP_ERROR_MSG_INVALID_SESSION_ID = 10324, 	/* 0x2854 */
        MSP_ERROR_MSG_INVALID_CONTENT = 10325, 	/* 0x2855 */

        /* Error codes of DataBase 10400(0x28A0)*/
        MSP_ERROR_DB_GENERAL = 10400, 	/* 0x28A0 */
        MSP_ERROR_DB_EXCEPTION = 10401, 	/* 0x28A1 */
        MSP_ERROR_DB_NO_RESULT = 10402, 	/* 0x28A2 */
        MSP_ERROR_DB_INVALID_USER = 10403, 	/* 0x28A3 */
        MSP_ERROR_DB_INVALID_PWD = 10404, 	/* 0x28A4 */
        MSP_ERROR_DB_CONNECT = 10405, 	/* 0x28A5 */
        MSP_ERROR_DB_INVALID_SQL = 10406, 	/* 0x28A6 */
        MSP_ERROR_DB_INVALID_APPID = 10407,	/* 0x28A7 */

        /* Error codes of Resource 10500(0x2904)*/
        MSP_ERROR_RES_GENERAL = 10500, 	/* 0x2904 */
        MSP_ERROR_RES_LOAD = 10501, 	/* 0x2905 */   /* Load resource */
        MSP_ERROR_RES_FREE = 10502, 	/* 0x2906 */   /* Free resource */
        MSP_ERROR_RES_MISSING = 10503, 	/* 0x2907 */   /* Resource File Missing */
        MSP_ERROR_RES_INVALID_NAME = 10504, 	/* 0x2908 */   /* Invalid resource file name */
        MSP_ERROR_RES_INVALID_ID = 10505, 	/* 0x2909 */   /* Invalid resource ID */
        MSP_ERROR_RES_INVALID_IMG = 10506, 	/* 0x290A */   /* Invalid resource image pointer */
        MSP_ERROR_RES_WRITE = 10507, 	/* 0x290B */   /* Write read-only resource */
        MSP_ERROR_RES_LEAK = 10508, 	/* 0x290C */   /* Resource leak out */
        MSP_ERROR_RES_HEAD = 10509, 	/* 0x290D */   /* Resource head currupt */
        MSP_ERROR_RES_DATA = 10510, 	/* 0x290E */   /* Resource data currupt */
        MSP_ERROR_RES_SKIP = 10511, 	/* 0x290F */   /* Resource file skipped */

        /* Error codes of TTS 10600(0x2968)*/
        MSP_ERROR_TTS_GENERAL = 10600, 	/* 0x2968 */
        MSP_ERROR_TTS_TEXTEND = 10601, 	/* 0x2969 */  /* Meet text end */
        MSP_ERROR_TTS_TEXT_EMPTY = 10602, 	/* 0x296A */  /* no synth text */
        MSP_ERROR_TTS_LTTS_ERROR = 10603, 	/* 0x296B */

        /* Error codes of Recognizer 10700(0x29CC) */
        MSP_ERROR_REC_GENERAL = 10700, 	/* 0x29CC */
        MSP_ERROR_REC_INACTIVE = 10701, 	/* 0x29CD */
        MSP_ERROR_REC_GRAMMAR_ERROR = 10702, 	/* 0x29CE */
        MSP_ERROR_REC_NO_ACTIVE_GRAMMARS = 10703, 	/* 0x29CF */
        MSP_ERROR_REC_DUPLICATE_GRAMMAR = 10704, 	/* 0x29D0 */
        MSP_ERROR_REC_INVALID_MEDIA_TYPE = 10705, 	/* 0x29D1 */
        MSP_ERROR_REC_INVALID_LANGUAGE = 10706, 	/* 0x29D2 */
        MSP_ERROR_REC_URI_NOT_FOUND = 10707, 	/* 0x29D3 */
        MSP_ERROR_REC_URI_TIMEOUT = 10708, 	/* 0x29D4 */
        MSP_ERROR_REC_URI_FETCH_ERROR = 10709, 	/* 0x29D5 */

        /* Error codes of Speech Detector 10800(0x2A30) */
        MSP_ERROR_EP_GENERAL = 10800, 	/* 0x2A30 */
        MSP_ERROR_EP_NO_SESSION_NAME = 10801, 	/* 0x2A31 */
        MSP_ERROR_EP_INACTIVE = 10802, 	/* 0x2A32 */
        MSP_ERROR_EP_INITIALIZED = 10803, 	/* 0x2A33 */

        /* Error codes of TUV */
        MSP_ERROR_TUV_GENERAL = 10900, 	/* 0x2A94 */
        MSP_ERROR_TUV_GETHIDPARAM = 10901, 	/* 0x2A95 */   /* Get Busin Param huanid*/
        MSP_ERROR_TUV_TOKEN = 10902, 	/* 0x2A96 */   /* Get Token */
        MSP_ERROR_TUV_CFGFILE = 10903, 	/* 0x2A97 */   /* Open cfg file */
        MSP_ERROR_TUV_RECV_CONTENT = 10904, 	/* 0x2A98 */   /* received content is error */
        MSP_ERROR_TUV_VERFAIL = 10905, 	/* 0x2A99 */   /* Verify failure */

        /* Error codes of IMTV */
        MSP_ERROR_LOGIN_SUCCESS = 11000, 	/* 0x2AF8 */   /* 成功 */
        MSP_ERROR_LOGIN_NO_LICENSE = 11001, 	/* 0x2AF9 */   /* 试用次数结束，用户需要付费 */
        MSP_ERROR_LOGIN_SESSIONID_INVALID = 11002, 	/* 0x2AFA */   /* SessionId失效，需要重新登录通行证 */
        MSP_ERROR_LOGIN_SESSIONID_ERROR = 11003, 	/* 0x2AFB */   /* SessionId为空，或者非法 */
        MSP_ERROR_LOGIN_UNLOGIN = 11004, 	/* 0x2AFC */   /* 未登录通行证 */
        MSP_ERROR_LOGIN_INVALID_USER = 11005, 	/* 0x2AFD */   /* 用户ID无效 */
        MSP_ERROR_LOGIN_INVALID_PWD = 11006, 	/* 0x2AFE */   /* 用户密码无效 */
        MSP_ERROR_LOGIN_SYSTEM_ERROR = 11099, 	/* 0x2B5B */   /* 系统错误 */

        /* Error Codes using in local engine */
        MSP_ERROR_AUTH_NO_LICENSE = 11200,	/* 0x2BC0 */   /* 无授权 */
        MSP_ERROR_AUTH_NO_ENOUGH_LICENSE = 11201,	/* 0x2BC1 */   /* 授权不足 */
        MSP_ERROR_AUTH_INVALID_LICENSE = 11202,	/* 0x2BC2 */   /* 无效的授权 */
        MSP_ERROR_AUTH_LICENSE_EXPIRED = 11203,	/* 0x2BC3 */   /* 授权过期 */
        MSP_ERROR_AUTH_NEED_MORE_DATA = 11204,    /* 0x2BC4 */   /* 无设备信息 */
        MSP_ERROR_AUTH_LICENSE_TO_BE_EXPIRED = 11205,	/* 0x2BC5 */   /* 授权即将过期，警告性错误码 */

        /* Error codes of HCR */
        MSP_ERROR_HCR_GENERAL = 11100,
        MSP_ERROR_HCR_RESOURCE_NOT_EXIST = 11101,
        MSP_ERROR_HCR_CREATE = 11102,
        MSP_ERROR_HCR_DESTROY = 11103,
        MSP_ERROR_HCR_START = 11104,
        MSP_ERROR_HCR_APPEND_STROKES = 11105,
        MSP_ERROR_HCR_INIT = 11106,
        MSP_ERROR_HCR_POINT_DECODE = 11107,
        MSP_ERROR_HCR_DISPATCH = 11108,
        MSP_ERROR_HCR_GETRESULT = 11109,
        MSP_ERROR_HCR_RESOURCE = 11110,




        /* Error codes of http 12000(0x2EE0) */
        MSP_ERROR_HTTP_BASE = 12000,	/* 0x2EE0 */

        /*Error codes of ISV */
        MSP_ERROR_ISV_NO_USER = 13000,	/* 32C8 */    /* the user doesn't exist */

        /* Error codes of Lua scripts */
        MSP_ERROR_LUA_BASE = 14000,    /* 0x36B0 */
        MSP_ERROR_LUA_YIELD = 14001,	/* 0x36B1 */
        MSP_ERROR_LUA_ERRRUN = 14002,	/* 0x36B2 */
        MSP_ERROR_LUA_ERRSYNTAX = 14003,	/* 0x36B3 */
        MSP_ERROR_LUA_ERRMEM = 14004,	/* 0x36B4 */
        MSP_ERROR_LUA_ERRERR = 14005,	/* 0x36B5 */
        MSP_ERROR_LUA_INVALID_PARAM = 14006,	/* 0x36B6 */

        /* Error codes of MMP */
        MSP_ERROR_MMP_BASE = 15000,    /* 0x3A98 */
        MSP_ERROR_MMP_MYSQL_INITFAIL = 15001,	/* 0x3A99 */
        MSP_ERROR_MMP_REDIS_INITFAIL = 15002,	/* 0x3A9A */
        MSP_ERROR_MMP_NETDSS_INITFAIL = 15003,	/* 0x3A9B */
        MSP_ERROR_MMP_TAIR_INITFAIL = 15004,	/* 0x3A9C */
        MSP_ERROR_MMP_MAIL_SESSION_FAIL = 15006,	/* 0x3A9E */	/* 邮件登陆服务器时，会话错误。*/
        MSP_ERROR_MMP_MAIL_LOGON_FAIL = 15007,	/* 0x3A9F */	/* 邮件登陆服务器时，拒绝登陆。*/
        MSP_ERROR_MMP_MAIL_USER_ILLEGAL = 15008,	/* 0x3AA0 */	/* 邮件登陆服务器时，用户名非法。*/
        MSP_ERROR_MMP_MAIL_PWD_ERR = 15009,	/* 0x3AA1 */	/* 邮件登陆服务器时，密码错误。*/
        MSP_ERROR_MMP_MAIL_SOCKET_ERR = 15010,	/* 0x3AA2 */	/* 邮件发送过程中套接字错误*/
        MSP_ERROR_MMP_MAIL_INIT_FAIL = 15011,	/* 0x3AA3 */	/* 邮件初始化错误*/
        MSP_ERROR_MMP_STORE_MNR_NO_INIT = 15012,	/* 0x3AA4 */	/* store_manager未初始化，或初始化失败*/
        MSP_ERROR_MMP_STORE_MNR_POOL_FULL = 15013,	/* 0x3AA5 */	/* store_manager的连接池满了*/
        MSP_ERROR_MMP_STRATGY_PARAM_ILLEGAL = 15014,	/* 0x3AA6 */	/* 报警策略表达式非法*/
        MSP_ERROR_MMP_STRATGY_PARAM_TOOLOOG = 15015,	/* 0x3AA7 */	/* 报警策略表达式太长*/
        MSP_ERROR_MMP_PARAM_NULL = 15016,	/* 0x3AA8 */	/* 函数参数为空*/
        MSP_ERROR_MMP_ERR_MORE_TOTAL = 15017,	/* 0x3AA9 */	/* pms插入数据库中错误汇总表的数据，错误次数 > 总次数。*/
        MSP_ERROR_MMP_PROC_THRESHOLD = 15018,	/* 0x3AAA */	/* 进程监控阀值设置错误*/
        MSP_ERROR_MMP_SERVER_THRESHOLD = 15019,	/* 0x3AAB */	/* 服务器监控阀值设置错误*/
        MSP_ERROR_MMP_PYTHON_NO_EXIST = 15020,    /* 0x3AAC */	/* python脚本文件不存在 */
        MSP_ERROR_MMP_PYTHON_IMPORT_FAILED = 15021,	/* 0x3AAD */	/* python脚本导入出错 */
        MSP_ERROR_MMP_PYTHON_BAD_FUNC = 15022,	/* 0x3AAE */	/* python脚本函数格式错误 */
        MSP_ERROR_MMP_DB_DATA_ILLEGAL = 15023,	/* 0x3AAF */	/* 插入数据库中的数据格式有误 */
        MSP_ERROR_MMP_REDIS_NOT_CONN = 15024,	/* 0x3AB0 */	/* redis没有连接到服务端 */
        MSP_ERROR_MMP_PMA_NOT_FOUND_STRATEGY = 15025,	/* 0x3AB1 */	/* 没有找到报警策略 */
        MSP_ERROR_MMP_TAIR_CONNECT = 15026,	/* 0x3AB2 */	/* 连接tair集群失败 */
        MSP_ERROR_MMP_PMC_SERVINFO_INVALID = 15027,	/* Ox3AB3 */	/* 此pmc的服务器信息已经无效 */
        MSP_ERROR_MMP_ALARM_GROUP_NULL = 15028,	/* Ox3AB4 */	/* 服务器报警的短信报警组与邮件报警组均为空 */
        MSP_ERROR_MMP_ALARM_CONTXT_NULL = 15029,	/* Ox3AB5 */	/* 服务器报警的报警内容为空 */

        /* Error codes of MSC(lmod loader) */
        MSP_ERROR_LMOD_BASE = 16000,	/* 0x3E80 */
        MSP_ERROR_LMOD_NOT_FOUND = 16001,	/* 0x3E81 */	/* 没找到lmod文件 */
        MSP_ERROR_LMOD_UNEXPECTED_BIN = 16002,	/* 0x3E82 */	/* 无效的lmod */
        MSP_ERROR_LMOD_LOADCODE = 16003,	/* 0x3E83 */	/* 加载lmod指令失败 */
        MSP_ERROR_LMOD_PRECALL = 16004,	/* 0x3E84 */	/* 初始化lmod失败 */
        MSP_ERROR_LMOD_RUNTIME_EXCEPTION = 16005,	/* 0x3E85 */	/* lmod运行时异常 */
        MSP_ERROR_LMOD_ALREADY_LOADED = 16006,	/* 0x3E86 */	/* lmod重复加载 */

        // Error code of Third Business
        MSP_ERROR_BIZ_BASE = 17000,	/* 0x4268 */	/* lmod重复加载 */

        //Error of Nginx errlog file increase exception
        MSP_ERROR_NGX_LOG_MORE_TOTEL_SIZE = 18000, 
    }

    public enum SynthStatus {
        MSP_TTS_FLAG_STILL_HAVE_DATA = 1,
        MSP_TTS_FLAG_DATA_END,
        MSP_TTS_FLAG_CMD_CANCELED
    }

    

    public interface ITTS {

        void speakFinished(string msg);
    }

    public class TTS
    {

        private const string CATHERINE = "catherine";
        private const string HENRY = "henry";

        private string sessionID;

        private string _speaker =CATHERINE;

        [DllImport("msc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int MSPLogin(string usr,string pwd,string configs);

        [DllImport("msc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr QTTSSessionBegin(string _params, ref int errorCode);

        [DllImport("msc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QTTSTextPut(string sessionID, string textString, uint textLen, string _params);

        [DllImport("msc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr QTTSAudioGet(string sessionID, ref int audioLen, ref SynthStatus synthStatus, ref int errorCode);

        [DllImport("msc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr QTTSAudioInfo(string sessionID);

        [DllImport("msc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QTTSSessionEnd(string sessionID, string hints);

        [DllImport("msc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QTTSGetParam(string sessionID, string paramName, string paramValue, ref uint valueLen);

        [DllImport("msc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int MSPLogout();

        //事件委托
        public delegate void TTS_SpeakFinished(string msg);
        public event TTS_SpeakFinished tts_SpeakFinishedEvent;

        public TTS(string config) {
            int ret = TTS.MSPLogin("","",config);
            if (ret != 0) {
                throw new Exception("初始化TTS引擎错误，错误代码：" + ret);
            }
        }

        /// <summary>
        /// wave文件头
        /// </summary>
        private struct WAVE_Header
        {
            public int RIFF_ID;           //4 byte , 'RIFF'
            public int File_Size;         //4 byte , 文件长度
            public int RIFF_Type;         //4 byte , 'WAVE'

            public int FMT_ID;            //4 byte , 'fmt'
            public int FMT_Size;          //4 byte , 数值为16或18，18则最后又附加信息
            public short FMT_Tag;          //2 byte , 编码方式，一般为0x0001
            public ushort FMT_Channel;     //2 byte , 声道数目，1--单声道；2--双声道
            public int FMT_SamplesPerSec;//4 byte , 采样频率
            public int AvgBytesPerSec;   //4 byte , 每秒所需字节数,记录每秒的数据量
            public ushort BlockAlign;      //2 byte , 数据块对齐单位(每个采样需要的字节数)
            public ushort BitsPerSample;   //2 byte , 每个采样需要的bit数

            public int DATA_ID;           //4 byte , 'data'
            public int DATA_Size;         //4 byte , 
        }

        /// <summary>
        /// 根据数据段的长度，生产文件头
        /// </summary>
        /// <param name="data_len">音频数据长度</param>
        /// <returns>返回wav文件头结构体</returns>
        WAVE_Header getWave_Header(int data_len)
        {
            WAVE_Header wav_Header = new WAVE_Header();
            wav_Header.RIFF_ID = 0x46464952;        //字符RIFF
            wav_Header.File_Size = data_len + 36;
            wav_Header.RIFF_Type = 0x45564157;      //字符WAVE

            wav_Header.FMT_ID = 0x20746D66;         //字符fmt
            wav_Header.FMT_Size = 16;
            wav_Header.FMT_Tag = 0x0001;
            wav_Header.FMT_Channel = 1;             //单声道
            wav_Header.FMT_SamplesPerSec = 16000;   //采样频率
            wav_Header.AvgBytesPerSec = 32000;      //每秒所需字节数
            wav_Header.BlockAlign = 2;              //每个采样1个字节
            wav_Header.BitsPerSample = 16;           //每个采样8bit

            wav_Header.DATA_ID = 0x61746164;        //字符data
            wav_Header.DATA_Size = data_len;

            return wav_Header;
        }

        /// <summary>
        /// 把结构体转化为字节序列
        /// </summary>
        /// <param name="structure">被转化的结构体</param>
        /// <returns>返回字节序列</returns>
        Byte[] StructToBytes(Object structure)
        {
            Int32 size = Marshal.SizeOf(structure);
            IntPtr buffer = Marshal.AllocHGlobal(size);
            try
            {
                Marshal.StructureToPtr(structure, buffer, false);
                Byte[] bytes = new Byte[size];
                Marshal.Copy(buffer, bytes, 0, size);
                return bytes;
            }
            finally
            {
                Marshal.FreeHGlobal(buffer);
            }
        }

        /// <summary>
        /// 指针转字符串
        /// </summary>
        /// <param name="p">指向非托管代码字符串的指针</param>
        /// <returns>返回指针指向的字符串</returns>
        public static string Ptr2Str(IntPtr p)
        {
            List<byte> lb = new List<byte>();
            while (Marshal.ReadByte(p) != 0)
            {
                lb.Add(Marshal.ReadByte(p));
                //p = p + 1;
                p = new IntPtr(p.ToInt32() + 1);
            }
            byte[] bs = lb.ToArray();
            return Encoding.Default.GetString(lb.ToArray());
        }

        /// <summary>
        /// 把文字转化为声音,单路配置，一种语音
        /// </summary>
        /// <param name="speekText">要转化成语音的文字</param>
        /// <param name="outWaveFlie">把声音转为文件，默认为不生产wave文件</param>
        private void speek(string speekText, string outWaveFlie = null)
        {
            
            string szParams = "ssm=0,ent=intp65_en,vcn="+_speaker+",aue=speex-wb;7,auf=audio/L16;rate=16000";
            int ret = 0;
            try
            {
                sessionID = Ptr2Str(TTS.QTTSSessionBegin(szParams, ref ret));
                if (ret != 0) throw new Exception("初始化TTS引会话错误，错误代码：" + ret);

                ret = TTS.QTTSTextPut(sessionID, speekText, (uint)Encoding.Default.GetByteCount(speekText), string.Empty);
                if (ret != 0) throw new Exception("向服务器发送数据，错误代码：" + ret);
                IntPtr audio_data;
                int audio_len = 0;
                SynthStatus synth_status = SynthStatus.MSP_TTS_FLAG_STILL_HAVE_DATA;

                MemoryStream ms = new MemoryStream();
                ms.Write(new byte[44], 0, 44);                              //写44字节的空文件头

                while (synth_status == SynthStatus.MSP_TTS_FLAG_STILL_HAVE_DATA)
                {
                    audio_data = TTS.QTTSAudioGet(sessionID, ref audio_len, ref synth_status, ref ret);
                    //System.Diagnostics.Debug.WriteLine("audio_len:"+audio_len);
                    if (audio_data!=IntPtr.Zero) {
                        //System.Diagnostics.Debug.WriteLine(">0");
                        byte[] data = new byte[audio_len];
                        Marshal.Copy(audio_data, data, 0, audio_len);
                        //System.Diagnostics.Debug.WriteLine("data.length:"+data.Length);
                        ms.Write(data, 0, data.Length);
                        //System.Diagnostics.Debug.WriteLine("write end");
                        if (synth_status == SynthStatus.MSP_TTS_FLAG_DATA_END || ret != 0)
                        {
                            //System.Diagnostics.Debug.WriteLine("break");
                            break;
                        }
                    }

                }
                System.Diagnostics.Debug.WriteLine("wav header");
                WAVE_Header header = getWave_Header((int)ms.Length - 44);     //创建wav文件头
                byte[] headerByte = StructToBytes(header);                         //把文件头结构转化为字节数组                      //写入文件头
                ms.Position = 0;                                                        //定位到文件头
                ms.Write(headerByte, 0, headerByte.Length);                             //写入文件头
                /*
                System.Diagnostics.Debug.WriteLine("play");
                ms.Position = 0;
                System.Media.SoundPlayer pl = new System.Media.SoundPlayer(ms);
                pl.Stop();
                pl.Play();
                 */
                if (outWaveFlie != null)
                {
                    //System.Diagnostics.Debug.WriteLine("outWaveFile:"+outWaveFlie);
                    FileStream fs = new FileStream(outWaveFlie, FileMode.Create);
                    ms.WriteTo(fs);
                    ms.Close();
                    fs.Close();
                    ms = null;
                    fs = null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error:"+ex.Message);
                
            }
            finally
            {
                ret = TTS.QTTSSessionEnd(sessionID, "");
                if (ret != 0) throw new Exception("结束TTS会话错误，错误代码：" + ret);

                
            }
        }
        /// <summary>
        /// 批量生成
        /// </summary>
        /// <param name="speakText">多行文本</param>
        /// <param name="outWaveFolder">音频生成目录</param>
        public void multiSpeak(string speakText, string outWaveFolder = null, bool custom = false)
        {

            string[] speakTexts = System.Text.RegularExpressions.Regex.Split(speakText,"\r\n");
            for (int i = 0; i < speakTexts.Length; i++) {

                string lineStr = speakTexts[i].Trim();
                if (lineStr == "") {
                    if (tts_SpeakFinishedEvent != null)
                    {
                        tts_SpeakFinishedEvent("第"+(i+1).ToString()+"行空白行跳过");
                    }
                    continue;
                }
                
                //选择了奇偶间隔发音
                if (custom)
                {
                    _speaker = i % 2 == 0 ? CATHERINE : HENRY;

                }
                else {
                    //设置了讲话者
                    int pos = lineStr.IndexOf('#');//#位置
                    if (pos > 0)
                    {
                        //_speaker = lineStr.Substring(0, pos).ToLower().Trim();
                        _speaker= lineStr.Substring(0, pos).ToLower().Trim().Equals(HENRY)?HENRY:CATHERINE;
                        lineStr = lineStr.Substring(pos + 1, lineStr.Length - pos - 1).Trim();
                    }
                    else
                    {
                        _speaker = CATHERINE;
                    }
                }
                System.Diagnostics.Debug.WriteLine(_speaker);
                
                //生成文件名,英文字符以外的替换为下划线
                string fileName = System.Text.RegularExpressions.Regex.Replace(lineStr, @"[^A-Za-z]", "_");
                //判断文件名长度
                if (fileName.Length > 30) {
                    fileName = fileName.Substring(0, 30);
                }
                //拼接随机数,防止重名
                fileName += new Random().Next(10000, 99999);
                this.speek(lineStr, outWaveFolder + @"\" + fileName.ToLower()+".wav");

                if (tts_SpeakFinishedEvent != null)
                {
                    tts_SpeakFinishedEvent("第"+(i+1).ToString()+"行操作完成");
                }
            }
            if (tts_SpeakFinishedEvent != null)
            {
                tts_SpeakFinishedEvent("全部操作完成");
            }
        

        }

        public void end() {
            TTS.MSPLogout();
        }

        

    }
}
