namespace ssConectaProveedores {
/// <summary>
/// [Structure] MultiUploadInvoiceFileStruct (4SlXYDjh30aKy5aw85FTNQ)
///  <code>ST_5478c3bb197e3019856d4a634c17d91dStructure</code> that represent
/// s <code>MultiUploadInvoiceFileStruct</code> <p>Description: Exportations file Struct for multi
///  upload files</p>
/// </summary>
// Name: MultiUploadInvoiceFileStruct
public partial struct ST_5478c3bb197e3019856d4a634c17d91dStructure : ITypedRecord<ST_5478c3bb197e3019856d4a634c17d91dStructure> {
internal static readonly GlobalObjectKey IdInvoiceFileId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*jh3dyjVuz0WAyBIT51wO0A");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*jgLS7O6DRk6sBO8dV+igLg");
internal static readonly GlobalObjectKey IdBinaryDataZIP = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*TeSna+mIyUqjgrL3ItA5dQ");
internal static readonly GlobalObjectKey IdBinaryDataXML = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*wImI90CSRkKt6iL4lvI6pg");
internal static readonly GlobalObjectKey IdBinaryDataPDF = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ZPN_+GS5J0CBLjQToxvDmQ");
internal static readonly GlobalObjectKey IdStorageId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*lRrakt6r8EycewKGybAVhg");
internal static readonly GlobalObjectKey IdErrorMsg = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*tBOMasGHjUiM_EdHr7mG1w");
internal static readonly GlobalObjectKey IdFileId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*qk7ZofP5Vkq4HnNAqcx4sw");

public long ssInvoiceFileId;

public string ssName;

public byte[] ssBinaryDataZIP;

public byte[] ssBinaryDataXML;

public byte[] ssBinaryDataPDF;

public long ssStorageId;

public string ssErrorMsg;

public long ssFileId;


public BitArray OptimizedAttributes;

public ST_5478c3bb197e3019856d4a634c17d91dStructure() {
OptimizedAttributes = null;
ssInvoiceFileId = 0L;
ssName = "";
ssBinaryDataZIP = new byte[] {};
ssBinaryDataXML = new byte[] {};
ssBinaryDataPDF = new byte[] {};
ssStorageId = 0L;
ssErrorMsg = "";
ssFileId = 0L;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssInvoiceFileId = r.ReadEntityReferenceLongInteger(index++, "MultiUploadInvoiceFileStruct.InvoiceFileId", 0L);
ssName = r.ReadText(index++, "MultiUploadInvoiceFileStruct.Name", "");
ssBinaryDataZIP = r.ReadBinaryData(index++, "MultiUploadInvoiceFileStruct.BinaryDataZIP", new byte[] {});
ssBinaryDataXML = r.ReadBinaryData(index++, "MultiUploadInvoiceFileStruct.BinaryDataXML", new byte[] {});
ssBinaryDataPDF = r.ReadBinaryData(index++, "MultiUploadInvoiceFileStruct.BinaryDataPDF", new byte[] {});
ssStorageId = r.ReadEntityReferenceLongInteger(index++, "MultiUploadInvoiceFileStruct.StorageId", 0L);
ssErrorMsg = r.ReadText(index++, "MultiUploadInvoiceFileStruct.ErrorMsg", "");
ssFileId = r.ReadEntityReferenceLongInteger(index++, "MultiUploadInvoiceFileStruct.FileId", 0L);
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(ST_5478c3bb197e3019856d4a634c17d91dStructure r) {
this = r;
}


public static bool operator == (ST_5478c3bb197e3019856d4a634c17d91dStructure a, ST_5478c3bb197e3019856d4a634c17d91dStructure b) {
if (a.ssInvoiceFileId != b.ssInvoiceFileId) return false;
if (a.ssName != b.ssName) return false;
if (!RuntimePlatformUtils.CompareByteArrays(a.ssBinaryDataZIP, b.ssBinaryDataZIP)) return false;
if (!RuntimePlatformUtils.CompareByteArrays(a.ssBinaryDataXML, b.ssBinaryDataXML)) return false;
if (!RuntimePlatformUtils.CompareByteArrays(a.ssBinaryDataPDF, b.ssBinaryDataPDF)) return false;
if (a.ssStorageId != b.ssStorageId) return false;
if (a.ssErrorMsg != b.ssErrorMsg) return false;
if (a.ssFileId != b.ssFileId) return false;
return true;
}

public static bool operator != (ST_5478c3bb197e3019856d4a634c17d91dStructure a, ST_5478c3bb197e3019856d4a634c17d91dStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_5478c3bb197e3019856d4a634c17d91dStructure)) return false;
return (this == (ST_5478c3bb197e3019856d4a634c17d91dStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssInvoiceFileId.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssBinaryDataZIP.GetHashCode()
 ^ ssBinaryDataXML.GetHashCode()
 ^ ssBinaryDataPDF.GetHashCode()
 ^ ssStorageId.GetHashCode()
 ^ ssErrorMsg.GetHashCode()
 ^ ssFileId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_5478c3bb197e3019856d4a634c17d91dStructure Duplicate() {
ST_5478c3bb197e3019856d4a634c17d91dStructure t;
t.ssInvoiceFileId = this.ssInvoiceFileId;
t.ssName = this.ssName;
t.ssBinaryDataZIP = this.ssBinaryDataZIP;
t.ssBinaryDataXML = this.ssBinaryDataXML;
t.ssBinaryDataPDF = this.ssBinaryDataPDF;
t.ssStorageId = this.ssStorageId;
t.ssErrorMsg = this.ssErrorMsg;
t.ssFileId = this.ssFileId;
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "invoicefileid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceFileId")) variable.Value = ssInvoiceFileId; else variable.Optimized = true;
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "binarydatazip") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BinaryDataZIP")) variable.Value = ssBinaryDataZIP; else variable.Optimized = true;
} else if (head == "binarydataxml") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BinaryDataXML")) variable.Value = ssBinaryDataXML; else variable.Optimized = true;
} else if (head == "binarydatapdf") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BinaryDataPDF")) variable.Value = ssBinaryDataPDF; else variable.Optimized = true;
} else if (head == "storageid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StorageId")) variable.Value = ssStorageId; else variable.Optimized = true;
} else if (head == "errormsg") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ErrorMsg")) variable.Value = ssErrorMsg; else variable.Optimized = true;
} else if (head == "fileid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FileId")) variable.Value = ssFileId; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoiceFileId) {
return ssInvoiceFileId;
}
if (key == IdName) {
return ssName;
}
if (key == IdBinaryDataZIP) {
return ssBinaryDataZIP;
}
if (key == IdBinaryDataXML) {
return ssBinaryDataXML;
}
if (key == IdBinaryDataPDF) {
return ssBinaryDataPDF;
}
if (key == IdStorageId) {
return ssStorageId;
}
if (key == IdErrorMsg) {
return ssErrorMsg;
}
if (key == IdFileId) {
return ssFileId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceFileId.Key.AsGuid) {
return ssInvoiceFileId;
}
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdBinaryDataZIP.Key.AsGuid) {
return ssBinaryDataZIP;
}
if (attributeKey == IdBinaryDataXML.Key.AsGuid) {
return ssBinaryDataXML;
}
if (attributeKey == IdBinaryDataPDF.Key.AsGuid) {
return ssBinaryDataPDF;
}
if (attributeKey == IdStorageId.Key.AsGuid) {
return ssStorageId;
}
if (attributeKey == IdErrorMsg.Key.AsGuid) {
return ssErrorMsg;
}
if (attributeKey == IdFileId.Key.AsGuid) {
return ssFileId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssInvoiceFileId = (long) other.AttributeGet(IdInvoiceFileId);
ssName = (string) other.AttributeGet(IdName);
ssBinaryDataZIP = (byte[]) other.AttributeGet(IdBinaryDataZIP);
ssBinaryDataXML = (byte[]) other.AttributeGet(IdBinaryDataXML);
ssBinaryDataPDF = (byte[]) other.AttributeGet(IdBinaryDataPDF);
ssStorageId = (long) other.AttributeGet(IdStorageId);
ssErrorMsg = (string) other.AttributeGet(IdErrorMsg);
ssFileId = (long) other.AttributeGet(IdFileId);
}
} // ST_5478c3bb197e3019856d4a634c17d91dStructure
/// <summary>
/// RecordList type <code>MultiUploadInvoiceFileStructList</code> that represents a record list of
///  <code>MultiUploadInvoiceFileStruct</code>
/// </summary>
public partial class RL_2e76d5be11218f97ffd872b5a7213337 : GenericRecordList<ST_5478c3bb197e3019856d4a634c17d91dStructure>, IEnumerable, IEnumerator {

protected override ST_5478c3bb197e3019856d4a634c17d91dStructure GetElementDefaultValue() {
return new ST_5478c3bb197e3019856d4a634c17d91dStructure();
}

public T[] ToArray<T>(Func<ST_5478c3bb197e3019856d4a634c17d91dStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2e76d5be11218f97ffd872b5a7213337 recordList, Func<ST_5478c3bb197e3019856d4a634c17d91dStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2e76d5be11218f97ffd872b5a7213337(ST_5478c3bb197e3019856d4a634c17d91dStructure[] array) {
  RL_2e76d5be11218f97ffd872b5a7213337 result = new RL_2e76d5be11218f97ffd872b5a7213337();
result.InnerFromArray(array);
    return result;
}

public static RL_2e76d5be11218f97ffd872b5a7213337 ToList<T>(T[] array, Func <T, ST_5478c3bb197e3019856d4a634c17d91dStructure> converter) {
  RL_2e76d5be11218f97ffd872b5a7213337 result = new RL_2e76d5be11218f97ffd872b5a7213337();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2e76d5be11218f97ffd872b5a7213337 FromRestList<T>(RestList<T> restList, Func <T, ST_5478c3bb197e3019856d4a634c17d91dStructure> converter) {
  RL_2e76d5be11218f97ffd872b5a7213337 result = new RL_2e76d5be11218f97ffd872b5a7213337();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2e76d5be11218f97ffd872b5a7213337() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_5478c3bb197e3019856d4a634c17d91dStructure> NewList() {
return new RL_2e76d5be11218f97ffd872b5a7213337();
}


} // RL_2e76d5be11218f97ffd872b5a7213337
}

