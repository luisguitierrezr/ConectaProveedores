namespace ssConectaProveedores {
/// <summary>
/// [Structure] InvoiceFileStruct (RghO5cePg0yxsOQb2ghazg)
///  <code>ST_7837994e68174a4794f15e4233b48555Structure</code> that represent
/// s <code>InvoiceFileStruct</code> <p>Description: Exportations file Struct.</p>
/// </summary>
// Name: InvoiceFileStruct
public partial struct ST_7837994e68174a4794f15e4233b48555Structure : ITypedRecord<ST_7837994e68174a4794f15e4233b48555Structure> {
internal static readonly GlobalObjectKey IdInvoiceFileId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*8ms+8U8LMkOC13CJO6ap6A");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ezrDNwGFOUS_4C_EFUCCOA");
internal static readonly GlobalObjectKey IdBinaryData = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*aETOOHbl+Uyam7Rx7H+E7w");
internal static readonly GlobalObjectKey IdStorageId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ne9zE5ZowkKT5ftggb_Tzw");
internal static readonly GlobalObjectKey IdFileId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*OuXG6opi30miclROVls58Q");

public long ssInvoiceFileId;

public string ssName;

public byte[] ssBinaryData;

public long ssStorageId;

public long ssFileId;


public BitArray OptimizedAttributes;

public ST_7837994e68174a4794f15e4233b48555Structure() {
OptimizedAttributes = null;
ssInvoiceFileId = 0L;
ssName = "";
ssBinaryData = new byte[] {};
ssStorageId = 0L;
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
ssInvoiceFileId = r.ReadEntityReferenceLongInteger(index++, "InvoiceFileStruct.InvoiceFileId", 0L);
ssName = r.ReadText(index++, "InvoiceFileStruct.Name", "");
ssBinaryData = r.ReadBinaryData(index++, "InvoiceFileStruct.BinaryData", new byte[] {});
ssStorageId = r.ReadEntityReferenceLongInteger(index++, "InvoiceFileStruct.StorageId", 0L);
ssFileId = r.ReadEntityReferenceLongInteger(index++, "InvoiceFileStruct.FileId", 0L);
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
public void ReadIM(ST_7837994e68174a4794f15e4233b48555Structure r) {
this = r;
}


public static bool operator == (ST_7837994e68174a4794f15e4233b48555Structure a, ST_7837994e68174a4794f15e4233b48555Structure b) {
if (a.ssInvoiceFileId != b.ssInvoiceFileId) return false;
if (a.ssName != b.ssName) return false;
if (!RuntimePlatformUtils.CompareByteArrays(a.ssBinaryData, b.ssBinaryData)) return false;
if (a.ssStorageId != b.ssStorageId) return false;
if (a.ssFileId != b.ssFileId) return false;
return true;
}

public static bool operator != (ST_7837994e68174a4794f15e4233b48555Structure a, ST_7837994e68174a4794f15e4233b48555Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_7837994e68174a4794f15e4233b48555Structure)) return false;
return (this == (ST_7837994e68174a4794f15e4233b48555Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssInvoiceFileId.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssBinaryData.GetHashCode()
 ^ ssStorageId.GetHashCode()
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


public ST_7837994e68174a4794f15e4233b48555Structure Duplicate() {
ST_7837994e68174a4794f15e4233b48555Structure t;
t.ssInvoiceFileId = this.ssInvoiceFileId;
t.ssName = this.ssName;
t.ssBinaryData = this.ssBinaryData;
t.ssStorageId = this.ssStorageId;
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
} else if (head == "binarydata") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BinaryData")) variable.Value = ssBinaryData; else variable.Optimized = true;
} else if (head == "storageid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StorageId")) variable.Value = ssStorageId; else variable.Optimized = true;
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
if (key == IdBinaryData) {
return ssBinaryData;
}
if (key == IdStorageId) {
return ssStorageId;
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
if (attributeKey == IdBinaryData.Key.AsGuid) {
return ssBinaryData;
}
if (attributeKey == IdStorageId.Key.AsGuid) {
return ssStorageId;
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
ssBinaryData = (byte[]) other.AttributeGet(IdBinaryData);
ssStorageId = (long) other.AttributeGet(IdStorageId);
ssFileId = (long) other.AttributeGet(IdFileId);
}
} // ST_7837994e68174a4794f15e4233b48555Structure
/// <summary>
/// RecordList type <code>InvoiceFileStructList</code> that represents a record list of
///  <code>InvoiceFileStruct</code>
/// </summary>
public partial class RL_7b4ceb84b6a1255d3a42c8932279bc3c : GenericRecordList<ST_7837994e68174a4794f15e4233b48555Structure>, IEnumerable, IEnumerator {

protected override ST_7837994e68174a4794f15e4233b48555Structure GetElementDefaultValue() {
return new ST_7837994e68174a4794f15e4233b48555Structure();
}

public T[] ToArray<T>(Func<ST_7837994e68174a4794f15e4233b48555Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7b4ceb84b6a1255d3a42c8932279bc3c recordList, Func<ST_7837994e68174a4794f15e4233b48555Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7b4ceb84b6a1255d3a42c8932279bc3c(ST_7837994e68174a4794f15e4233b48555Structure[] array) {
  RL_7b4ceb84b6a1255d3a42c8932279bc3c result = new RL_7b4ceb84b6a1255d3a42c8932279bc3c();
result.InnerFromArray(array);
    return result;
}

public static RL_7b4ceb84b6a1255d3a42c8932279bc3c ToList<T>(T[] array, Func <T, ST_7837994e68174a4794f15e4233b48555Structure> converter) {
  RL_7b4ceb84b6a1255d3a42c8932279bc3c result = new RL_7b4ceb84b6a1255d3a42c8932279bc3c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7b4ceb84b6a1255d3a42c8932279bc3c FromRestList<T>(RestList<T> restList, Func <T, ST_7837994e68174a4794f15e4233b48555Structure> converter) {
  RL_7b4ceb84b6a1255d3a42c8932279bc3c result = new RL_7b4ceb84b6a1255d3a42c8932279bc3c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7b4ceb84b6a1255d3a42c8932279bc3c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_7837994e68174a4794f15e4233b48555Structure> NewList() {
return new RL_7b4ceb84b6a1255d3a42c8932279bc3c();
}


} // RL_7b4ceb84b6a1255d3a42c8932279bc3c
}

