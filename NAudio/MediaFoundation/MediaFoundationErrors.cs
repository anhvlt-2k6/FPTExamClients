﻿using System;

namespace NAudio.MediaFoundation
{
    public static class MediaFoundationErrors
    {
        public const int MF_E_PLATFORM_NOT_INITIALIZED = -1072875856;

        public const int MF_E_BUFFERTOOSMALL = -1072875855;

        public const int MF_E_INVALIDREQUEST = -1072875854;

        public const int MF_E_INVALIDSTREAMNUMBER = -1072875853;

        public const int MF_E_INVALIDMEDIATYPE = -1072875852;

        public const int MF_E_NOTACCEPTING = -1072875851;

        public const int MF_E_NOT_INITIALIZED = -1072875850;

        public const int MF_E_UNSUPPORTED_REPRESENTATION = -1072875849;

        public const int MF_E_NO_MORE_TYPES = -1072875847;

        public const int MF_E_UNSUPPORTED_SERVICE = -1072875846;

        public const int MF_E_UNEXPECTED = -1072875845;

        public const int MF_E_INVALIDNAME = -1072875844;

        public const int MF_E_INVALIDTYPE = -1072875843;

        public const int MF_E_INVALID_FILE_FORMAT = -1072875842;

        public const int MF_E_INVALIDINDEX = -1072875841;

        public const int MF_E_INVALID_TIMESTAMP = -1072875840;

        public const int MF_E_UNSUPPORTED_SCHEME = -1072875837;

        public const int MF_E_UNSUPPORTED_BYTESTREAM_TYPE = -1072875836;

        public const int MF_E_UNSUPPORTED_TIME_FORMAT = -1072875835;

        public const int MF_E_NO_SAMPLE_TIMESTAMP = -1072875832;

        public const int MF_E_NO_SAMPLE_DURATION = -1072875831;

        public const int MF_E_INVALID_STREAM_DATA = -1072875829;

        public const int MF_E_RT_UNAVAILABLE = -1072875825;

        public const int MF_E_UNSUPPORTED_RATE = -1072875824;

        public const int MF_E_THINNING_UNSUPPORTED = -1072875823;

        public const int MF_E_REVERSE_UNSUPPORTED = -1072875822;

        public const int MF_E_UNSUPPORTED_RATE_TRANSITION = -1072875821;

        public const int MF_E_RATE_CHANGE_PREEMPTED = -1072875820;

        public const int MF_E_NOT_FOUND = -1072875819;

        public const int MF_E_NOT_AVAILABLE = -1072875818;

        public const int MF_E_NO_CLOCK = -1072875817;

        public const int MF_S_MULTIPLE_BEGIN = 866008;

        public const int MF_E_MULTIPLE_BEGIN = -1072875815;

        public const int MF_E_MULTIPLE_SUBSCRIBERS = -1072875814;

        public const int MF_E_TIMER_ORPHANED = -1072875813;

        public const int MF_E_STATE_TRANSITION_PENDING = -1072875812;

        public const int MF_E_UNSUPPORTED_STATE_TRANSITION = -1072875811;

        public const int MF_E_UNRECOVERABLE_ERROR_OCCURRED = -1072875810;

        public const int MF_E_SAMPLE_HAS_TOO_MANY_BUFFERS = -1072875809;

        public const int MF_E_SAMPLE_NOT_WRITABLE = -1072875808;

        public const int MF_E_INVALID_KEY = -1072875806;

        public const int MF_E_BAD_STARTUP_VERSION = -1072875805;

        public const int MF_E_UNSUPPORTED_CAPTION = -1072875804;

        public const int MF_E_INVALID_POSITION = -1072875803;

        public const int MF_E_ATTRIBUTENOTFOUND = -1072875802;

        public const int MF_E_PROPERTY_TYPE_NOT_ALLOWED = -1072875801;

        public const int MF_E_PROPERTY_TYPE_NOT_SUPPORTED = -1072875800;

        public const int MF_E_PROPERTY_EMPTY = -1072875799;

        public const int MF_E_PROPERTY_NOT_EMPTY = -1072875798;

        public const int MF_E_PROPERTY_VECTOR_NOT_ALLOWED = -1072875797;

        public const int MF_E_PROPERTY_VECTOR_REQUIRED = -1072875796;

        public const int MF_E_OPERATION_CANCELLED = -1072875795;

        public const int MF_E_BYTESTREAM_NOT_SEEKABLE = -1072875794;

        public const int MF_E_DISABLED_IN_SAFEMODE = -1072875793;

        public const int MF_E_CANNOT_PARSE_BYTESTREAM = -1072875792;

        public const int MF_E_SOURCERESOLVER_MUTUALLY_EXCLUSIVE_FLAGS = -1072875791;

        public const int MF_E_MEDIAPROC_WRONGSTATE = -1072875790;

        public const int MF_E_RT_THROUGHPUT_NOT_AVAILABLE = -1072875789;

        public const int MF_E_RT_TOO_MANY_CLASSES = -1072875788;

        public const int MF_E_RT_WOULDBLOCK = -1072875787;

        public const int MF_E_NO_BITPUMP = -1072875786;

        public const int MF_E_RT_OUTOFMEMORY = -1072875785;

        public const int MF_E_RT_WORKQUEUE_CLASS_NOT_SPECIFIED = -1072875784;

        public const int MF_E_INSUFFICIENT_BUFFER = -1072860816;

        public const int MF_E_CANNOT_CREATE_SINK = -1072875782;

        public const int MF_E_BYTESTREAM_UNKNOWN_LENGTH = -1072875781;

        public const int MF_E_SESSION_PAUSEWHILESTOPPED = -1072875780;

        public const int MF_S_ACTIVATE_REPLACED = 866045;

        public const int MF_E_FORMAT_CHANGE_NOT_SUPPORTED = -1072875778;

        public const int MF_E_INVALID_WORKQUEUE = -1072875777;

        public const int MF_E_DRM_UNSUPPORTED = -1072875776;

        public const int MF_E_UNAUTHORIZED = -1072875775;

        public const int MF_E_OUT_OF_RANGE = -1072875774;

        public const int MF_E_INVALID_CODEC_MERIT = -1072875773;

        public const int MF_E_HW_MFT_FAILED_START_STREAMING = -1072875772;

        public const int MF_S_ASF_PARSEINPROGRESS = 1074608792;

        public const int MF_E_ASF_PARSINGINCOMPLETE = -1072874856;

        public const int MF_E_ASF_MISSINGDATA = -1072874855;

        public const int MF_E_ASF_INVALIDDATA = -1072874854;

        public const int MF_E_ASF_OPAQUEPACKET = -1072874853;

        public const int MF_E_ASF_NOINDEX = -1072874852;

        public const int MF_E_ASF_OUTOFRANGE = -1072874851;

        public const int MF_E_ASF_INDEXNOTLOADED = -1072874850;

        public const int MF_E_ASF_TOO_MANY_PAYLOADS = -1072874849;

        public const int MF_E_ASF_UNSUPPORTED_STREAM_TYPE = -1072874848;

        public const int MF_E_ASF_DROPPED_PACKET = -1072874847;

        public const int MF_E_NO_EVENTS_AVAILABLE = -1072873856;

        public const int MF_E_INVALID_STATE_TRANSITION = -1072873854;

        public const int MF_E_END_OF_STREAM = -1072873852;

        public const int MF_E_SHUTDOWN = -1072873851;

        public const int MF_E_MP3_NOTFOUND = -1072873850;

        public const int MF_E_MP3_OUTOFDATA = -1072873849;

        public const int MF_E_MP3_NOTMP3 = -1072873848;

        public const int MF_E_MP3_NOTSUPPORTED = -1072873847;

        public const int MF_E_NO_DURATION = -1072873846;

        public const int MF_E_INVALID_FORMAT = -1072873844;

        public const int MF_E_PROPERTY_NOT_FOUND = -1072873843;

        public const int MF_E_PROPERTY_READ_ONLY = -1072873842;

        public const int MF_E_PROPERTY_NOT_ALLOWED = -1072873841;

        public const int MF_E_MEDIA_SOURCE_NOT_STARTED = -1072873839;

        public const int MF_E_UNSUPPORTED_FORMAT = -1072873832;

        public const int MF_E_MP3_BAD_CRC = -1072873831;

        public const int MF_E_NOT_PROTECTED = -1072873830;

        public const int MF_E_MEDIA_SOURCE_WRONGSTATE = -1072873829;

        public const int MF_E_MEDIA_SOURCE_NO_STREAMS_SELECTED = -1072873828;

        public const int MF_E_CANNOT_FIND_KEYFRAME_SAMPLE = -1072873827;

        public const int MF_E_NETWORK_RESOURCE_FAILURE = -1072872856;

        public const int MF_E_NET_WRITE = -1072872855;

        public const int MF_E_NET_READ = -1072872854;

        public const int MF_E_NET_REQUIRE_NETWORK = -1072872853;

        public const int MF_E_NET_REQUIRE_ASYNC = -1072872852;

        public const int MF_E_NET_BWLEVEL_NOT_SUPPORTED = -1072872851;

        public const int MF_E_NET_STREAMGROUPS_NOT_SUPPORTED = -1072872850;

        public const int MF_E_NET_MANUALSS_NOT_SUPPORTED = -1072872849;

        public const int MF_E_NET_INVALID_PRESENTATION_DESCRIPTOR = -1072872848;

        public const int MF_E_NET_CACHESTREAM_NOT_FOUND = -1072872847;

        public const int MF_I_MANUAL_PROXY = 1074610802;

        public const int MF_E_NET_REQUIRE_INPUT = -1072872844;

        public const int MF_E_NET_REDIRECT = -1072872843;

        public const int MF_E_NET_REDIRECT_TO_PROXY = -1072872842;

        public const int MF_E_NET_TOO_MANY_REDIRECTS = -1072872841;

        public const int MF_E_NET_TIMEOUT = -1072872840;

        public const int MF_E_NET_CLIENT_CLOSE = -1072872839;

        public const int MF_E_NET_BAD_CONTROL_DATA = -1072872838;

        public const int MF_E_NET_INCOMPATIBLE_SERVER = -1072872837;

        public const int MF_E_NET_UNSAFE_URL = -1072872836;

        public const int MF_E_NET_CACHE_NO_DATA = -1072872835;

        public const int MF_E_NET_EOL = -1072872834;

        public const int MF_E_NET_BAD_REQUEST = -1072872833;

        public const int MF_E_NET_INTERNAL_SERVER_ERROR = -1072872832;

        public const int MF_E_NET_SESSION_NOT_FOUND = -1072872831;

        public const int MF_E_NET_NOCONNECTION = -1072872830;

        public const int MF_E_NET_CONNECTION_FAILURE = -1072872829;

        public const int MF_E_NET_INCOMPATIBLE_PUSHSERVER = -1072872828;

        public const int MF_E_NET_SERVER_ACCESSDENIED = -1072872827;

        public const int MF_E_NET_PROXY_ACCESSDENIED = -1072872826;

        public const int MF_E_NET_CANNOTCONNECT = -1072872825;

        public const int MF_E_NET_INVALID_PUSH_TEMPLATE = -1072872824;

        public const int MF_E_NET_INVALID_PUSH_PUBLISHING_POINT = -1072872823;

        public const int MF_E_NET_BUSY = -1072872822;

        public const int MF_E_NET_RESOURCE_GONE = -1072872821;

        public const int MF_E_NET_ERROR_FROM_PROXY = -1072872820;

        public const int MF_E_NET_PROXY_TIMEOUT = -1072872819;

        public const int MF_E_NET_SERVER_UNAVAILABLE = -1072872818;

        public const int MF_E_NET_TOO_MUCH_DATA = -1072872817;

        public const int MF_E_NET_SESSION_INVALID = -1072872816;

        public const int MF_E_OFFLINE_MODE = -1072872815;

        public const int MF_E_NET_UDP_BLOCKED = -1072872814;

        public const int MF_E_NET_UNSUPPORTED_CONFIGURATION = -1072872813;

        public const int MF_E_NET_PROTOCOL_DISABLED = -1072872812;

        public const int MF_E_ALREADY_INITIALIZED = -1072871856;

        public const int MF_E_BANDWIDTH_OVERRUN = -1072871855;

        public const int MF_E_LATE_SAMPLE = -1072871854;

        public const int MF_E_FLUSH_NEEDED = -1072871853;

        public const int MF_E_INVALID_PROFILE = -1072871852;

        public const int MF_E_INDEX_NOT_COMMITTED = -1072871851;

        public const int MF_E_NO_INDEX = -1072871850;

        public const int MF_E_CANNOT_INDEX_IN_PLACE = -1072871849;

        public const int MF_E_MISSING_ASF_LEAKYBUCKET = -1072871848;

        public const int MF_E_INVALID_ASF_STREAMID = -1072871847;

        public const int MF_E_STREAMSINK_REMOVED = -1072870856;

        public const int MF_E_STREAMSINKS_OUT_OF_SYNC = -1072870854;

        public const int MF_E_STREAMSINKS_FIXED = -1072870853;

        public const int MF_E_STREAMSINK_EXISTS = -1072870852;

        public const int MF_E_SAMPLEALLOCATOR_CANCELED = -1072870851;

        public const int MF_E_SAMPLEALLOCATOR_EMPTY = -1072870850;

        public const int MF_E_SINK_ALREADYSTOPPED = -1072870849;

        public const int MF_E_ASF_FILESINK_BITRATE_UNKNOWN = -1072870848;

        public const int MF_E_SINK_NO_STREAMS = -1072870847;

        public const int MF_S_SINK_NOT_FINALIZED = 870978;

        public const int MF_E_METADATA_TOO_LONG = -1072870845;

        public const int MF_E_SINK_NO_SAMPLES_PROCESSED = -1072870844;

        public const int MF_E_VIDEO_REN_NO_PROCAMP_HW = -1072869856;

        public const int MF_E_VIDEO_REN_NO_DEINTERLACE_HW = -1072869855;

        public const int MF_E_VIDEO_REN_COPYPROT_FAILED = -1072869854;

        public const int MF_E_VIDEO_REN_SURFACE_NOT_SHARED = -1072869853;

        public const int MF_E_VIDEO_DEVICE_LOCKED = -1072869852;

        public const int MF_E_NEW_VIDEO_DEVICE = -1072869851;

        public const int MF_E_NO_VIDEO_SAMPLE_AVAILABLE = -1072869850;

        public const int MF_E_NO_AUDIO_PLAYBACK_DEVICE = -1072869756;

        public const int MF_E_AUDIO_PLAYBACK_DEVICE_IN_USE = -1072869755;

        public const int MF_E_AUDIO_PLAYBACK_DEVICE_INVALIDATED = -1072869754;

        public const int MF_E_AUDIO_SERVICE_NOT_RUNNING = -1072869753;

        public const int MF_E_TOPO_INVALID_OPTIONAL_NODE = -1072868850;

        public const int MF_E_TOPO_CANNOT_FIND_DECRYPTOR = -1072868847;

        public const int MF_E_TOPO_CODEC_NOT_FOUND = -1072868846;

        public const int MF_E_TOPO_CANNOT_CONNECT = -1072868845;

        public const int MF_E_TOPO_UNSUPPORTED = -1072868844;

        public const int MF_E_TOPO_INVALID_TIME_ATTRIBUTES = -1072868843;

        public const int MF_E_TOPO_LOOPS_IN_TOPOLOGY = -1072868842;

        public const int MF_E_TOPO_MISSING_PRESENTATION_DESCRIPTOR = -1072868841;

        public const int MF_E_TOPO_MISSING_STREAM_DESCRIPTOR = -1072868840;

        public const int MF_E_TOPO_STREAM_DESCRIPTOR_NOT_SELECTED = -1072868839;

        public const int MF_E_TOPO_MISSING_SOURCE = -1072868838;

        public const int MF_E_TOPO_SINK_ACTIVATES_UNSUPPORTED = -1072868837;

        public const int MF_E_SEQUENCER_UNKNOWN_SEGMENT_ID = -1072864852;

        public const int MF_S_SEQUENCER_CONTEXT_CANCELED = 876973;

        public const int MF_E_NO_SOURCE_IN_CACHE = -1072864850;

        public const int MF_S_SEQUENCER_SEGMENT_AT_END_OF_STREAM = 876975;

        public const int MF_E_TRANSFORM_TYPE_NOT_SET = -1072861856;

        public const int MF_E_TRANSFORM_STREAM_CHANGE = -1072861855;

        public const int MF_E_TRANSFORM_INPUT_REMAINING = -1072861854;

        public const int MF_E_TRANSFORM_PROFILE_MISSING = -1072861853;

        public const int MF_E_TRANSFORM_PROFILE_INVALID_OR_CORRUPT = -1072861852;

        public const int MF_E_TRANSFORM_PROFILE_TRUNCATED = -1072861851;

        public const int MF_E_TRANSFORM_PROPERTY_PID_NOT_RECOGNIZED = -1072861850;

        public const int MF_E_TRANSFORM_PROPERTY_VARIANT_TYPE_WRONG = -1072861849;

        public const int MF_E_TRANSFORM_PROPERTY_NOT_WRITEABLE = -1072861848;

        public const int MF_E_TRANSFORM_PROPERTY_ARRAY_VALUE_WRONG_NUM_DIM = -1072861847;

        public const int MF_E_TRANSFORM_PROPERTY_VALUE_SIZE_WRONG = -1072861846;

        public const int MF_E_TRANSFORM_PROPERTY_VALUE_OUT_OF_RANGE = -1072861845;

        public const int MF_E_TRANSFORM_PROPERTY_VALUE_INCOMPATIBLE = -1072861844;

        public const int MF_E_TRANSFORM_NOT_POSSIBLE_FOR_CURRENT_OUTPUT_MEDIATYPE = -1072861843;

        public const int MF_E_TRANSFORM_NOT_POSSIBLE_FOR_CURRENT_INPUT_MEDIATYPE = -1072861842;

        public const int MF_E_TRANSFORM_NOT_POSSIBLE_FOR_CURRENT_MEDIATYPE_COMBINATION = -1072861841;

        public const int MF_E_TRANSFORM_CONFLICTS_WITH_OTHER_CURRENTLY_ENABLED_FEATURES = -1072861840;

        public const int MF_E_TRANSFORM_NEED_MORE_INPUT = -1072861838;

        public const int MF_E_TRANSFORM_NOT_POSSIBLE_FOR_CURRENT_SPKR_CONFIG = -1072861837;

        public const int MF_E_TRANSFORM_CANNOT_CHANGE_MEDIATYPE_WHILE_PROCESSING = -1072861836;

        public const int MF_S_TRANSFORM_DO_NOT_PROPAGATE_EVENT = 879989;

        public const int MF_E_UNSUPPORTED_D3D_TYPE = -1072861834;

        public const int MF_E_TRANSFORM_ASYNC_LOCKED = -1072861833;

        public const int MF_E_TRANSFORM_CANNOT_INITIALIZE_ACM_DRIVER = -1072861832;

        public const int MF_E_LICENSE_INCORRECT_RIGHTS = -1072860856;

        public const int MF_E_LICENSE_OUTOFDATE = -1072860855;

        public const int MF_E_LICENSE_REQUIRED = -1072860854;

        public const int MF_E_DRM_HARDWARE_INCONSISTENT = -1072860853;

        public const int MF_E_NO_CONTENT_PROTECTION_MANAGER = -1072860852;

        public const int MF_E_LICENSE_RESTORE_NO_RIGHTS = -1072860851;

        public const int MF_E_BACKUP_RESTRICTED_LICENSE = -1072860850;

        public const int MF_E_LICENSE_RESTORE_NEEDS_INDIVIDUALIZATION = -1072860849;

        public const int MF_S_PROTECTION_NOT_REQUIRED = 880976;

        public const int MF_E_COMPONENT_REVOKED = -1072860847;

        public const int MF_E_TRUST_DISABLED = -1072860846;

        public const int MF_E_WMDRMOTA_NO_ACTION = -1072860845;

        public const int MF_E_WMDRMOTA_ACTION_ALREADY_SET = -1072860844;

        public const int MF_E_WMDRMOTA_DRM_HEADER_NOT_AVAILABLE = -1072860843;

        public const int MF_E_WMDRMOTA_DRM_ENCRYPTION_SCHEME_NOT_SUPPORTED = -1072860842;

        public const int MF_E_WMDRMOTA_ACTION_MISMATCH = -1072860841;

        public const int MF_E_WMDRMOTA_INVALID_POLICY = -1072860840;

        public const int MF_E_POLICY_UNSUPPORTED = -1072860839;

        public const int MF_E_OPL_NOT_SUPPORTED = -1072860838;

        public const int MF_E_TOPOLOGY_VERIFICATION_FAILED = -1072860837;

        public const int MF_E_SIGNATURE_VERIFICATION_FAILED = -1072860836;

        public const int MF_E_DEBUGGING_NOT_ALLOWED = -1072860835;

        public const int MF_E_CODE_EXPIRED = -1072860834;

        public const int MF_E_GRL_VERSION_TOO_LOW = -1072860833;

        public const int MF_E_GRL_RENEWAL_NOT_FOUND = -1072860832;

        public const int MF_E_GRL_EXTENSIBLE_ENTRY_NOT_FOUND = -1072860831;

        public const int MF_E_KERNEL_UNTRUSTED = -1072860830;

        public const int MF_E_PEAUTH_UNTRUSTED = -1072860829;

        public const int MF_E_NON_PE_PROCESS = -1072860827;

        public const int MF_E_REBOOT_REQUIRED = -1072860825;

        public const int MF_S_WAIT_FOR_POLICY_SET = 881000;

        public const int MF_S_VIDEO_DISABLED_WITH_UNKNOWN_SOFTWARE_OUTPUT = 881001;

        public const int MF_E_GRL_INVALID_FORMAT = -1072860822;

        public const int MF_E_GRL_UNRECOGNIZED_FORMAT = -1072860821;

        public const int MF_E_ALL_PROCESS_RESTART_REQUIRED = -1072860820;

        public const int MF_E_PROCESS_RESTART_REQUIRED = -1072860819;

        public const int MF_E_USERMODE_UNTRUSTED = -1072860818;

        public const int MF_E_PEAUTH_SESSION_NOT_STARTED = -1072860817;

        public const int MF_E_PEAUTH_PUBLICKEY_REVOKED = -1072860815;

        public const int MF_E_GRL_ABSENT = -1072860814;

        public const int MF_S_PE_TRUSTED = 881011;

        public const int MF_E_PE_UNTRUSTED = -1072860812;

        public const int MF_E_PEAUTH_NOT_STARTED = -1072860811;

        public const int MF_E_INCOMPATIBLE_SAMPLE_PROTECTION = -1072860810;

        public const int MF_E_PE_SESSIONS_MAXED = -1072860809;

        public const int MF_E_HIGH_SECURITY_LEVEL_CONTENT_NOT_ALLOWED = -1072860808;

        public const int MF_E_TEST_SIGNED_COMPONENTS_NOT_ALLOWED = -1072860807;

        public const int MF_E_ITA_UNSUPPORTED_ACTION = -1072860806;

        public const int MF_E_ITA_ERROR_PARSING_SAP_PARAMETERS = -1072860805;

        public const int MF_E_POLICY_MGR_ACTION_OUTOFBOUNDS = -1072860804;

        public const int MF_E_BAD_OPL_STRUCTURE_FORMAT = -1072860803;

        public const int MF_E_ITA_UNRECOGNIZED_ANALOG_VIDEO_PROTECTION_GUID = -1072860802;

        public const int MF_E_NO_PMP_HOST = -1072860801;

        public const int MF_E_ITA_OPL_DATA_NOT_INITIALIZED = -1072860800;

        public const int MF_E_ITA_UNRECOGNIZED_ANALOG_VIDEO_OUTPUT = -1072860799;

        public const int MF_E_ITA_UNRECOGNIZED_DIGITAL_VIDEO_OUTPUT = -1072860798;

        public const int MF_E_CLOCK_INVALID_CONTINUITY_KEY = -1072849856;

        public const int MF_E_CLOCK_NO_TIME_SOURCE = -1072849855;

        public const int MF_E_CLOCK_STATE_ALREADY_SET = -1072849854;

        public const int MF_E_CLOCK_NOT_SIMPLE = -1072849853;

        public const int MF_S_CLOCK_STOPPED = 891972;

        public const int MF_E_NO_MORE_DROP_MODES = -1072848856;

        public const int MF_E_NO_MORE_QUALITY_LEVELS = -1072848855;

        public const int MF_E_DROPTIME_NOT_SUPPORTED = -1072848854;

        public const int MF_E_QUALITYKNOB_WAIT_LONGER = -1072848853;

        public const int MF_E_QM_INVALIDSTATE = -1072848852;

        public const int MF_E_TRANSCODE_NO_CONTAINERTYPE = -1072847856;

        public const int MF_E_TRANSCODE_PROFILE_NO_MATCHING_STREAMS = -1072847855;

        public const int MF_E_TRANSCODE_NO_MATCHING_ENCODER = -1072847854;

        public const int MF_E_ALLOCATOR_NOT_INITIALIZED = -1072846856;

        public const int MF_E_ALLOCATOR_NOT_COMMITED = -1072846855;

        public const int MF_E_ALLOCATOR_ALREADY_COMMITED = -1072846854;

        public const int MF_E_STREAM_ERROR = -1072846853;

        public const int MF_E_INVALID_STREAM_STATE = -1072846852;

        public const int MF_E_HW_STREAM_NOT_CONNECTED = -1072846851;
    }
}
