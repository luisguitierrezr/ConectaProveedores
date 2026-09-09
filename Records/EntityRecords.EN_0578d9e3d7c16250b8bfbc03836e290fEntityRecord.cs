using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] BusinessValueCategory (oUjSCCdQdU+V2gRHLzYfCQ)
///  <code>EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord</code> that represent
/// s <code>BusinessValueCategory</code> <p>Description: Entity holds categories.</p>
/// </summary>
// Name: BusinessValueCategory
public partial struct EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord : ITypedRecord<EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*r3vlrw38zUe6_2krYT8Hng");
internal static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*Hue1S57roUq8DMFJfS7SQQ");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*jlEGFTd1GECYY_pGyMmLlg");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*KUOxUn4JH0KhX5SGDyFjGw");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*iG0qzWItrUeL1k4ll_VaNg");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*YSAiIJ8En0i5pryXt4UyYg");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(6,true);
          _ssId = value;
      }
  }
}

private string _ssDescription;
public string ssDescription{
  get{
      return _ssDescription;
  }
  set{
      if((_ssDescription!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssDescription = value;
      }
  }
}

private DateTime _ssCreatedOn;
public DateTime ssCreatedOn{
  get{
      return _ssCreatedOn;
  }
  set{
      if((_ssCreatedOn!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssCreatedOn = value;
      }
  }
}

private string _ssCreatedBy;
public string ssCreatedBy{
  get{
      return _ssCreatedBy;
  }
  set{
      if((_ssCreatedBy!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssCreatedBy = value;
      }
  }
}

private DateTime _ssUpdatedOn;
public DateTime ssUpdatedOn{
  get{
      return _ssUpdatedOn;
  }
  set{
      if((_ssUpdatedOn!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssUpdatedOn = value;
      }
  }
}

private string _ssUpdatedBy;
public string ssUpdatedBy{
  get{
      return _ssUpdatedBy;
  }
  set{
      if((_ssUpdatedBy!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssUpdatedBy = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord() {
ChangedAttributes = new BitArray(6,true);
OptimizedAttributes = new BitArray(6,false);
_ssId = 0L;
_ssDescription = "";
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssCreatedBy = "";
_ssUpdatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssUpdatedBy = "";
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
ssId = r.ReadLongInteger(index++, "BusinessValueCategory.Id", 0L);
ssDescription = r.ReadText(index++, "BusinessValueCategory.Description", "");
ssCreatedOn = r.ReadDateTime(index++, "BusinessValueCategory.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCreatedBy = r.ReadEntityReferenceText(index++, "BusinessValueCategory.CreatedBy", "");
ssUpdatedOn = r.ReadDateTime(index++, "BusinessValueCategory.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "BusinessValueCategory.UpdatedBy", "");
ChangedAttributes = new BitArray(6,false);
OptimizedAttributes = new BitArray(6,false);
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
public void ReadIM(EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord r) {
this = r;
}


public static bool operator == (EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord a, EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssDescription != b.ssDescription) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
return true;
}

public static bool operator != (EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord a, EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord)) return false;
return (this == (EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssDescription.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssUpdatedOn.GetHashCode()
 ^ ssUpdatedBy.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord Duplicate() {
EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord t;
t._ssId = this._ssId;
t._ssDescription = this._ssDescription;
t._ssCreatedOn = this._ssCreatedOn;
t._ssCreatedBy = this._ssCreatedBy;
t._ssUpdatedOn = this._ssUpdatedOn;
t._ssUpdatedBy = this._ssUpdatedBy;
t.ChangedAttributes = new BitArray(6);
t.OptimizedAttributes = new BitArray(6);
for(int i = 0; i < 6; i++){
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
} else if (head == "description") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "updatedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedOn")) variable.Value = ssUpdatedOn; else variable.Optimized = true;
} else if (head == "updatedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedBy")) variable.Value = ssUpdatedBy; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdDescription)) {
return ChangedAttributes[1];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[2];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[3];
}
if (key.Equals(IdUpdatedOn)) {
return ChangedAttributes[4];
}
if (key.Equals(IdUpdatedBy)) {
return ChangedAttributes[5];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdDescription)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdUpdatedOn)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdUpdatedBy)) {
return OptimizedAttributes[5];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdDescription) {
return ssDescription;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdUpdatedOn) {
return ssUpdatedOn;
}
if (key == IdUpdatedBy) {
return ssUpdatedBy;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdDescription.Key.AsGuid) {
return ssDescription;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdUpdatedOn.Key.AsGuid) {
return ssUpdatedOn;
}
if (attributeKey == IdUpdatedBy.Key.AsGuid) {
return ssUpdatedBy;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(6);
OptimizedAttributes = new BitArray(6);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssDescription = (string) other.AttributeGet(IdDescription);
ChangedAttributes[1] = other.ChangedAttributeGet(IdDescription);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdDescription);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[2] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdCreatedOn);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[3] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdCreatedBy);
ssUpdatedOn = (DateTime) other.AttributeGet(IdUpdatedOn);
ChangedAttributes[4] = other.ChangedAttributeGet(IdUpdatedOn);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdUpdatedOn);
ssUpdatedBy = (string) other.AttributeGet(IdUpdatedBy);
ChangedAttributes[5] = other.ChangedAttributeGet(IdUpdatedBy);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdUpdatedBy);
}
} // EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord

/// <summary>
/// RecordList type <code>BusinessValueCategoryList</code> that represents a record list of
///  <code>BusinessValueCategory</code>
/// </summary>
public partial class RL_8e2ec77f051c5e9e1c7ed49cf8a8a855 : GenericRecordList<EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord>, IEnumerable, IEnumerator {

protected override EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord GetElementDefaultValue() {
return new EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord();
}

public T[] ToArray<T>(Func<EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8e2ec77f051c5e9e1c7ed49cf8a8a855 recordList, Func<EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8e2ec77f051c5e9e1c7ed49cf8a8a855(EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord[] array) {
  RL_8e2ec77f051c5e9e1c7ed49cf8a8a855 result = new RL_8e2ec77f051c5e9e1c7ed49cf8a8a855();
result.InnerFromArray(array);
    return result;
}

public static RL_8e2ec77f051c5e9e1c7ed49cf8a8a855 ToList<T>(T[] array, Func <T, EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord> converter) {
  RL_8e2ec77f051c5e9e1c7ed49cf8a8a855 result = new RL_8e2ec77f051c5e9e1c7ed49cf8a8a855();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8e2ec77f051c5e9e1c7ed49cf8a8a855 FromRestList<T>(RestList<T> restList, Func <T, EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord> converter) {
  RL_8e2ec77f051c5e9e1c7ed49cf8a8a855 result = new RL_8e2ec77f051c5e9e1c7ed49cf8a8a855();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8e2ec77f051c5e9e1c7ed49cf8a8a855() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord> NewList() {
return new RL_8e2ec77f051c5e9e1c7ed49cf8a8a855();
}


} // RL_8e2ec77f051c5e9e1c7ed49cf8a8a855
}
