using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] Department (Qzj5APIql0mrzfiCBmz1TA)
///  <code>EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord</code> that represent
/// s <code>Department</code> <p>Description: Entity holds all the departments.</p>
/// </summary>
// Name: Department
public partial struct EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord : ITypedRecord<EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*bL6F7Ch2Xk+HLXfDiuxQ2w");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*Co2MQAKUMUyQYirc30dJUA");
internal static readonly GlobalObjectKey IdIsActive = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*aGt_QtI+yEeuqAGDv8fnSw");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*2ADXFiNqMUO2N3W7czN0rQ");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*ztrQhQKQmkCj5fVldlBLtA");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*oHa7SmL8Zk2s49g0gHLyAw");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*6LzqTjDsqU2AE1xwlicZjg");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(7,true);
          _ssId = value;
      }
  }
}

private string _ssName;
public string ssName{
  get{
      return _ssName;
  }
  set{
      if((_ssName!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssName = value;
      }
  }
}

private bool _ssIsActive;
public bool ssIsActive{
  get{
      return _ssIsActive;
  }
  set{
      if((_ssIsActive!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssIsActive = value;
      }
  }
}

private DateTime _ssCreatedOn;
public DateTime ssCreatedOn{
  get{
      return _ssCreatedOn;
  }
  set{
      if((_ssCreatedOn!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
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
      if((_ssCreatedBy!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
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
      if((_ssUpdatedOn!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
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
      if((_ssUpdatedBy!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssUpdatedBy = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord() {
ChangedAttributes = new BitArray(7,true);
OptimizedAttributes = new BitArray(7,false);
_ssId = 0L;
_ssName = "";
_ssIsActive = true;
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
ssId = r.ReadLongInteger(index++, "Department.Id", 0L);
ssName = r.ReadText(index++, "Department.Name", "");
ssIsActive = r.ReadBoolean(index++, "Department.IsActive", true);
ssCreatedOn = r.ReadDateTime(index++, "Department.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCreatedBy = r.ReadEntityReferenceText(index++, "Department.CreatedBy", "");
ssUpdatedOn = r.ReadDateTime(index++, "Department.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "Department.UpdatedBy", "");
ChangedAttributes = new BitArray(7,false);
OptimizedAttributes = new BitArray(7,false);
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
public void ReadIM(EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord r) {
this = r;
}


public static bool operator == (EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord a, EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssName != b.ssName) return false;
if (a.ssIsActive != b.ssIsActive) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
return true;
}

public static bool operator != (EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord a, EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord)) return false;
return (this == (EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssIsActive.GetHashCode()
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


public EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord Duplicate() {
EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord t;
t._ssId = this._ssId;
t._ssName = this._ssName;
t._ssIsActive = this._ssIsActive;
t._ssCreatedOn = this._ssCreatedOn;
t._ssCreatedBy = this._ssCreatedBy;
t._ssUpdatedOn = this._ssUpdatedOn;
t._ssUpdatedBy = this._ssUpdatedBy;
t.ChangedAttributes = new BitArray(7);
t.OptimizedAttributes = new BitArray(7);
for(int i = 0; i < 7; i++){
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
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "isactive") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsActive")) variable.Value = ssIsActive; else variable.Optimized = true;
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
if (key.Equals(IdName)) {
return ChangedAttributes[1];
}
if (key.Equals(IdIsActive)) {
return ChangedAttributes[2];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[3];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[4];
}
if (key.Equals(IdUpdatedOn)) {
return ChangedAttributes[5];
}
if (key.Equals(IdUpdatedBy)) {
return ChangedAttributes[6];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdName)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdIsActive)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdUpdatedOn)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdUpdatedBy)) {
return OptimizedAttributes[6];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdName) {
return ssName;
}
if (key == IdIsActive) {
return ssIsActive;
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
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdIsActive.Key.AsGuid) {
return ssIsActive;
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
ChangedAttributes = new BitArray(7);
OptimizedAttributes = new BitArray(7);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssName = (string) other.AttributeGet(IdName);
ChangedAttributes[1] = other.ChangedAttributeGet(IdName);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdName);
ssIsActive = (bool) other.AttributeGet(IdIsActive);
ChangedAttributes[2] = other.ChangedAttributeGet(IdIsActive);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdIsActive);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[3] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdCreatedOn);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[4] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdCreatedBy);
ssUpdatedOn = (DateTime) other.AttributeGet(IdUpdatedOn);
ChangedAttributes[5] = other.ChangedAttributeGet(IdUpdatedOn);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdUpdatedOn);
ssUpdatedBy = (string) other.AttributeGet(IdUpdatedBy);
ChangedAttributes[6] = other.ChangedAttributeGet(IdUpdatedBy);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdUpdatedBy);
}
} // EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord

/// <summary>
/// RecordList type <code>DepartmentList</code> that represents a record list of
///  <code>Department</code>
/// </summary>
public partial class RL_76ade55be2e9364ad54649b1abdca962 : GenericRecordList<EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord>, IEnumerable, IEnumerator {

protected override EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord GetElementDefaultValue() {
return new EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord();
}

public T[] ToArray<T>(Func<EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_76ade55be2e9364ad54649b1abdca962 recordList, Func<EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_76ade55be2e9364ad54649b1abdca962(EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord[] array) {
  RL_76ade55be2e9364ad54649b1abdca962 result = new RL_76ade55be2e9364ad54649b1abdca962();
result.InnerFromArray(array);
    return result;
}

public static RL_76ade55be2e9364ad54649b1abdca962 ToList<T>(T[] array, Func <T, EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord> converter) {
  RL_76ade55be2e9364ad54649b1abdca962 result = new RL_76ade55be2e9364ad54649b1abdca962();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_76ade55be2e9364ad54649b1abdca962 FromRestList<T>(RestList<T> restList, Func <T, EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord> converter) {
  RL_76ade55be2e9364ad54649b1abdca962 result = new RL_76ade55be2e9364ad54649b1abdca962();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_76ade55be2e9364ad54649b1abdca962() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord> NewList() {
return new RL_76ade55be2e9364ad54649b1abdca962();
}


} // RL_76ade55be2e9364ad54649b1abdca962
}
