using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] Sustainability (w0wsZyMLrk+vesEdb5EA0Q)
///  <code>EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord</code> that represent
/// s <code>Sustainability</code> <p>Description: Entity holds sustainability options.</p>
/// </summary>
// Name: Sustainability
public partial struct EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord : ITypedRecord<EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*Qkz9cfUCwE2t5InS2AY1FA");
internal static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*df+l9r7Ah0e8mnUeWK+uiQ");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*fi6xBozDtU60vDdI_l3Jbw");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*H6fAnpmVpEqlyrKo0JFSxQ");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*FUi0NRGO7EWrb46lm_3Q9w");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*3eUahDxzNUiLoQxACLQZGg");
internal static readonly GlobalObjectKey IdIsActive = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*+hjslT+r+Eq4oXnxyRQmow");

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

private bool _ssIsActive;
public bool ssIsActive{
  get{
      return _ssIsActive;
  }
  set{
      if((_ssIsActive!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssIsActive = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord() {
ChangedAttributes = new BitArray(7,true);
OptimizedAttributes = new BitArray(7,false);
_ssId = 0L;
_ssDescription = "";
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssCreatedBy = "";
_ssUpdatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssUpdatedBy = "";
_ssIsActive = true;
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
ssId = r.ReadLongInteger(index++, "Sustainability.Id", 0L);
ssDescription = r.ReadText(index++, "Sustainability.Description", "");
ssCreatedOn = r.ReadDateTime(index++, "Sustainability.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCreatedBy = r.ReadEntityReferenceText(index++, "Sustainability.CreatedBy", "");
ssUpdatedOn = r.ReadDateTime(index++, "Sustainability.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "Sustainability.UpdatedBy", "");
ssIsActive = r.ReadBoolean(index++, "Sustainability.IsActive", true);
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
public void ReadIM(EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord r) {
this = r;
}


public static bool operator == (EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord a, EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssDescription != b.ssDescription) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
if (a.ssIsActive != b.ssIsActive) return false;
return true;
}

public static bool operator != (EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord a, EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord)) return false;
return (this == (EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord)o);
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
 ^ ssIsActive.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord Duplicate() {
EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord t;
t._ssId = this._ssId;
t._ssDescription = this._ssDescription;
t._ssCreatedOn = this._ssCreatedOn;
t._ssCreatedBy = this._ssCreatedBy;
t._ssUpdatedOn = this._ssUpdatedOn;
t._ssUpdatedBy = this._ssUpdatedBy;
t._ssIsActive = this._ssIsActive;
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
} else if (head == "isactive") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsActive")) variable.Value = ssIsActive; else variable.Optimized = true;
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
if (key.Equals(IdIsActive)) {
return ChangedAttributes[6];
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
if (key.Equals(IdIsActive)) {
return OptimizedAttributes[6];
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
if (key == IdIsActive) {
return ssIsActive;
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
if (attributeKey == IdIsActive.Key.AsGuid) {
return ssIsActive;
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
ssIsActive = (bool) other.AttributeGet(IdIsActive);
ChangedAttributes[6] = other.ChangedAttributeGet(IdIsActive);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdIsActive);
}
} // EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord

/// <summary>
/// RecordList type <code>SustainabilityList</code> that represents a record list of
///  <code>Sustainability</code>
/// </summary>
public partial class RL_2048ee7d2c5c652c13b17e7f9d85621b : GenericRecordList<EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord>, IEnumerable, IEnumerator {

protected override EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord GetElementDefaultValue() {
return new EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord();
}

public T[] ToArray<T>(Func<EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2048ee7d2c5c652c13b17e7f9d85621b recordList, Func<EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2048ee7d2c5c652c13b17e7f9d85621b(EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord[] array) {
  RL_2048ee7d2c5c652c13b17e7f9d85621b result = new RL_2048ee7d2c5c652c13b17e7f9d85621b();
result.InnerFromArray(array);
    return result;
}

public static RL_2048ee7d2c5c652c13b17e7f9d85621b ToList<T>(T[] array, Func <T, EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord> converter) {
  RL_2048ee7d2c5c652c13b17e7f9d85621b result = new RL_2048ee7d2c5c652c13b17e7f9d85621b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2048ee7d2c5c652c13b17e7f9d85621b FromRestList<T>(RestList<T> restList, Func <T, EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord> converter) {
  RL_2048ee7d2c5c652c13b17e7f9d85621b result = new RL_2048ee7d2c5c652c13b17e7f9d85621b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2048ee7d2c5c652c13b17e7f9d85621b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord> NewList() {
return new RL_2048ee7d2c5c652c13b17e7f9d85621b();
}


} // RL_2048ee7d2c5c652c13b17e7f9d85621b
}
