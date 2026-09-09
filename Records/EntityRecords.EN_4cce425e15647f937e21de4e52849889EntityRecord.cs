using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] RequisitionFile2 (MwVa7g6FekmLXZJfQzSEww)
///  <code>EN_4cce425e15647f937e21de4e52849889EntityRecord</code> that represent
/// s <code>RequisitionFile2</code> <p>Description: Entity that holds Requisition File.</p>
/// </summary>
// Name: RequisitionFile2
public partial struct EN_4cce425e15647f937e21de4e52849889EntityRecord : ITypedRecord<EN_4cce425e15647f937e21de4e52849889EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*jROTwjchDku_sns83W0h3Q");
internal static readonly GlobalObjectKey IdFilename = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*7Lx35fXYuEixVtyAkqW_3A");
internal static readonly GlobalObjectKey IdVENDOR = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*yCiAHyIN5U6bfnapzvKQUQ");
internal static readonly GlobalObjectKey IdDOC_TYPE = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*M01oTAF_t02FAKIWYjPDmg");
internal static readonly GlobalObjectKey IdSAP_OBJECT = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*g5oW+AQB20ODCxyessRlGQ");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*UVz3LrNdwkCofcUpgDAU3A");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Lp9zPXB4LkmNugMyiTVngw");
internal static readonly GlobalObjectKey IdStorageId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*7pZHXPcuz0OxPX83cZATMw");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(8,true);
          _ssId = value;
      }
  }
}

private string _ssFilename;
public string ssFilename{
  get{
      return _ssFilename;
  }
  set{
      if((_ssFilename!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssFilename = value;
      }
  }
}

private string _ssVENDOR;
public string ssVENDOR{
  get{
      return _ssVENDOR;
  }
  set{
      if((_ssVENDOR!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssVENDOR = value;
      }
  }
}

private string _ssDOC_TYPE;
public string ssDOC_TYPE{
  get{
      return _ssDOC_TYPE;
  }
  set{
      if((_ssDOC_TYPE!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssDOC_TYPE = value;
      }
  }
}

private string _ssSAP_OBJECT;
public string ssSAP_OBJECT{
  get{
      return _ssSAP_OBJECT;
  }
  set{
      if((_ssSAP_OBJECT!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssSAP_OBJECT = value;
      }
  }
}

private string _ssCreatedBy;
public string ssCreatedBy{
  get{
      return _ssCreatedBy;
  }
  set{
      if((_ssCreatedBy!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssCreatedBy = value;
      }
  }
}

private DateTime _ssCreatedOn;
public DateTime ssCreatedOn{
  get{
      return _ssCreatedOn;
  }
  set{
      if((_ssCreatedOn!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssCreatedOn = value;
      }
  }
}

private long _ssStorageId;
public long ssStorageId{
  get{
      return _ssStorageId;
  }
  set{
      if((_ssStorageId!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssStorageId = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_4cce425e15647f937e21de4e52849889EntityRecord() {
ChangedAttributes = new BitArray(8,true);
OptimizedAttributes = new BitArray(8,false);
_ssId = 0L;
_ssFilename = "";
_ssVENDOR = "";
_ssDOC_TYPE = "";
_ssSAP_OBJECT = "";
_ssCreatedBy = "";
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssStorageId = 0L;
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
ssId = r.ReadLongInteger(index++, "RequisitionFile2.Id", 0L);
ssFilename = r.ReadText(index++, "RequisitionFile2.Filename", "");
ssVENDOR = r.ReadText(index++, "RequisitionFile2.VENDOR", "");
ssDOC_TYPE = r.ReadText(index++, "RequisitionFile2.DOC_TYPE", "");
ssSAP_OBJECT = r.ReadText(index++, "RequisitionFile2.SAP_OBJECT", "");
ssCreatedBy = r.ReadEntityReferenceText(index++, "RequisitionFile2.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "RequisitionFile2.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssStorageId = r.ReadEntityReferenceLongInteger(index++, "RequisitionFile2.StorageId", 0L);
ChangedAttributes = new BitArray(8,false);
OptimizedAttributes = new BitArray(8,false);
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
public void ReadIM(EN_4cce425e15647f937e21de4e52849889EntityRecord r) {
this = r;
}


public static bool operator == (EN_4cce425e15647f937e21de4e52849889EntityRecord a, EN_4cce425e15647f937e21de4e52849889EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssFilename != b.ssFilename) return false;
if (a.ssVENDOR != b.ssVENDOR) return false;
if (a.ssDOC_TYPE != b.ssDOC_TYPE) return false;
if (a.ssSAP_OBJECT != b.ssSAP_OBJECT) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssStorageId != b.ssStorageId) return false;
return true;
}

public static bool operator != (EN_4cce425e15647f937e21de4e52849889EntityRecord a, EN_4cce425e15647f937e21de4e52849889EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_4cce425e15647f937e21de4e52849889EntityRecord)) return false;
return (this == (EN_4cce425e15647f937e21de4e52849889EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssFilename.GetHashCode()
 ^ ssVENDOR.GetHashCode()
 ^ ssDOC_TYPE.GetHashCode()
 ^ ssSAP_OBJECT.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssStorageId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_4cce425e15647f937e21de4e52849889EntityRecord Duplicate() {
EN_4cce425e15647f937e21de4e52849889EntityRecord t;
t._ssId = this._ssId;
t._ssFilename = this._ssFilename;
t._ssVENDOR = this._ssVENDOR;
t._ssDOC_TYPE = this._ssDOC_TYPE;
t._ssSAP_OBJECT = this._ssSAP_OBJECT;
t._ssCreatedBy = this._ssCreatedBy;
t._ssCreatedOn = this._ssCreatedOn;
t._ssStorageId = this._ssStorageId;
t.ChangedAttributes = new BitArray(8);
t.OptimizedAttributes = new BitArray(8);
for(int i = 0; i < 8; i++){
  t.ChangedAttributes[i] = ChangedAttributes[i];
  t.OptimizedAttributes[i] = OptimizedAttributes[i];
}
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
if (head == "id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Id")) variable.Value = ssId; else variable.Optimized = true;
} else if (head == "filename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Filename")) variable.Value = ssFilename; else variable.Optimized = true;
} else if (head == "vendor") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".VENDOR")) variable.Value = ssVENDOR; else variable.Optimized = true;
} else if (head == "doc_type") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DOC_TYPE")) variable.Value = ssDOC_TYPE; else variable.Optimized = true;
} else if (head == "sap_object") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SAP_OBJECT")) variable.Value = ssSAP_OBJECT; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "storageid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StorageId")) variable.Value = ssStorageId; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdFilename)) {
return ChangedAttributes[1];
}
if (key.Equals(IdVENDOR)) {
return ChangedAttributes[2];
}
if (key.Equals(IdDOC_TYPE)) {
return ChangedAttributes[3];
}
if (key.Equals(IdSAP_OBJECT)) {
return ChangedAttributes[4];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[5];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[6];
}
if (key.Equals(IdStorageId)) {
return ChangedAttributes[7];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdFilename)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdVENDOR)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdDOC_TYPE)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdSAP_OBJECT)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdStorageId)) {
return OptimizedAttributes[7];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdFilename) {
return ssFilename;
}
if (key == IdVENDOR) {
return ssVENDOR;
}
if (key == IdDOC_TYPE) {
return ssDOC_TYPE;
}
if (key == IdSAP_OBJECT) {
return ssSAP_OBJECT;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdStorageId) {
return ssStorageId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdFilename.Key.AsGuid) {
return ssFilename;
}
if (attributeKey == IdVENDOR.Key.AsGuid) {
return ssVENDOR;
}
if (attributeKey == IdDOC_TYPE.Key.AsGuid) {
return ssDOC_TYPE;
}
if (attributeKey == IdSAP_OBJECT.Key.AsGuid) {
return ssSAP_OBJECT;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdStorageId.Key.AsGuid) {
return ssStorageId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(8);
OptimizedAttributes = new BitArray(8);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssFilename = (string) other.AttributeGet(IdFilename);
ChangedAttributes[1] = other.ChangedAttributeGet(IdFilename);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdFilename);
ssVENDOR = (string) other.AttributeGet(IdVENDOR);
ChangedAttributes[2] = other.ChangedAttributeGet(IdVENDOR);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdVENDOR);
ssDOC_TYPE = (string) other.AttributeGet(IdDOC_TYPE);
ChangedAttributes[3] = other.ChangedAttributeGet(IdDOC_TYPE);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdDOC_TYPE);
ssSAP_OBJECT = (string) other.AttributeGet(IdSAP_OBJECT);
ChangedAttributes[4] = other.ChangedAttributeGet(IdSAP_OBJECT);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdSAP_OBJECT);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[5] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[6] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdCreatedOn);
ssStorageId = (long) other.AttributeGet(IdStorageId);
ChangedAttributes[7] = other.ChangedAttributeGet(IdStorageId);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdStorageId);
}
} // EN_4cce425e15647f937e21de4e52849889EntityRecord

/// <summary>
/// RecordList type <code>RequisitionFile2List</code> that represents a record list of
///  <code>RequisitionFile2</code>
/// </summary>
public partial class RL_446c9d1d04a71b61e91750aac0412a0e : GenericRecordList<EN_4cce425e15647f937e21de4e52849889EntityRecord>, IEnumerable, IEnumerator {

protected override EN_4cce425e15647f937e21de4e52849889EntityRecord GetElementDefaultValue() {
return new EN_4cce425e15647f937e21de4e52849889EntityRecord();
}

public T[] ToArray<T>(Func<EN_4cce425e15647f937e21de4e52849889EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_446c9d1d04a71b61e91750aac0412a0e recordList, Func<EN_4cce425e15647f937e21de4e52849889EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_446c9d1d04a71b61e91750aac0412a0e(EN_4cce425e15647f937e21de4e52849889EntityRecord[] array) {
  RL_446c9d1d04a71b61e91750aac0412a0e result = new RL_446c9d1d04a71b61e91750aac0412a0e();
result.InnerFromArray(array);
    return result;
}

public static RL_446c9d1d04a71b61e91750aac0412a0e ToList<T>(T[] array, Func <T, EN_4cce425e15647f937e21de4e52849889EntityRecord> converter) {
  RL_446c9d1d04a71b61e91750aac0412a0e result = new RL_446c9d1d04a71b61e91750aac0412a0e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_446c9d1d04a71b61e91750aac0412a0e FromRestList<T>(RestList<T> restList, Func <T, EN_4cce425e15647f937e21de4e52849889EntityRecord> converter) {
  RL_446c9d1d04a71b61e91750aac0412a0e result = new RL_446c9d1d04a71b61e91750aac0412a0e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_446c9d1d04a71b61e91750aac0412a0e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_4cce425e15647f937e21de4e52849889EntityRecord> NewList() {
return new RL_446c9d1d04a71b61e91750aac0412a0e();
}


} // RL_446c9d1d04a71b61e91750aac0412a0e
}
