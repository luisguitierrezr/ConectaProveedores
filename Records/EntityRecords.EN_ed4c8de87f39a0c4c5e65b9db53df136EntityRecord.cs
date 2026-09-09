using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] CustomSettingValue (TxAmGYR9K0+9fjY5Q+VSBw)
///  <code>EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord</code> that represent
/// s <code>CustomSettingValue</code> <p>Description: </p>
/// </summary>
// Name: CustomSettingValue
public partial struct EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord : ITypedRecord<EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*rIxdBVbnEEC_bp9W7JslBQ");
internal static readonly GlobalObjectKey IdCustomSettingId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*2cCYppp4rEqfjUS5wtIDdg");
internal static readonly GlobalObjectKey IdValue = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*DmwJFpK20EWfc_eHfNryPQ");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*6yrX+keEhU6yJT_nI_nlKg");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*tPrrIfZZj0KyOEs69RjnMg");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(5,true);
          _ssId = value;
      }
  }
}

private int _ssCustomSettingId;
public int ssCustomSettingId{
  get{
      return _ssCustomSettingId;
  }
  set{
      if((_ssCustomSettingId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssCustomSettingId = value;
      }
  }
}

private string _ssValue;
public string ssValue{
  get{
      return _ssValue;
  }
  set{
      if((_ssValue!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssValue = value;
      }
  }
}

private DateTime _ssUpdatedOn;
public DateTime ssUpdatedOn{
  get{
      return _ssUpdatedOn;
  }
  set{
      if((_ssUpdatedOn!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
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
      if((_ssUpdatedBy!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssUpdatedBy = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord() {
ChangedAttributes = new BitArray(5,true);
OptimizedAttributes = new BitArray(5,false);
_ssId = 0L;
_ssCustomSettingId = 0;
_ssValue = "";
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
ssId = r.ReadLongInteger(index++, "CustomSettingValue.Id", 0L);
ssCustomSettingId = r.ReadEntityReference(index++, "CustomSettingValue.CustomSettingId", 0);
ssValue = r.ReadText(index++, "CustomSettingValue.Value", "");
ssUpdatedOn = r.ReadDateTime(index++, "CustomSettingValue.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "CustomSettingValue.UpdatedBy", "");
ChangedAttributes = new BitArray(5,false);
OptimizedAttributes = new BitArray(5,false);
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
public void ReadIM(EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord r) {
this = r;
}


public static bool operator == (EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord a, EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssCustomSettingId != b.ssCustomSettingId) return false;
if (a.ssValue != b.ssValue) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
return true;
}

public static bool operator != (EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord a, EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord)) return false;
return (this == (EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssCustomSettingId.GetHashCode()
 ^ ssValue.GetHashCode()
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


public EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord Duplicate() {
EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord t;
t._ssId = this._ssId;
t._ssCustomSettingId = this._ssCustomSettingId;
t._ssValue = this._ssValue;
t._ssUpdatedOn = this._ssUpdatedOn;
t._ssUpdatedBy = this._ssUpdatedBy;
t.ChangedAttributes = new BitArray(5);
t.OptimizedAttributes = new BitArray(5);
for(int i = 0; i < 5; i++){
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
} else if (head == "customsettingid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CustomSettingId")) variable.Value = ssCustomSettingId; else variable.Optimized = true;
} else if (head == "value") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Value")) variable.Value = ssValue; else variable.Optimized = true;
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
if (key.Equals(IdCustomSettingId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdValue)) {
return ChangedAttributes[2];
}
if (key.Equals(IdUpdatedOn)) {
return ChangedAttributes[3];
}
if (key.Equals(IdUpdatedBy)) {
return ChangedAttributes[4];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdCustomSettingId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdValue)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdUpdatedOn)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdUpdatedBy)) {
return OptimizedAttributes[4];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdCustomSettingId) {
return ssCustomSettingId;
}
if (key == IdValue) {
return ssValue;
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
if (attributeKey == IdCustomSettingId.Key.AsGuid) {
return ssCustomSettingId;
}
if (attributeKey == IdValue.Key.AsGuid) {
return ssValue;
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
ChangedAttributes = new BitArray(5);
OptimizedAttributes = new BitArray(5);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssCustomSettingId = (int) other.AttributeGet(IdCustomSettingId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdCustomSettingId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdCustomSettingId);
ssValue = (string) other.AttributeGet(IdValue);
ChangedAttributes[2] = other.ChangedAttributeGet(IdValue);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdValue);
ssUpdatedOn = (DateTime) other.AttributeGet(IdUpdatedOn);
ChangedAttributes[3] = other.ChangedAttributeGet(IdUpdatedOn);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdUpdatedOn);
ssUpdatedBy = (string) other.AttributeGet(IdUpdatedBy);
ChangedAttributes[4] = other.ChangedAttributeGet(IdUpdatedBy);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdUpdatedBy);
}
} // EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord

/// <summary>
/// RecordList type <code>CustomSettingValueList</code> that represents a record list of
///  <code>CustomSettingValue</code>
/// </summary>
public partial class RL_4c958626af795efca6e20049d3d8be72 : GenericRecordList<EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord>, IEnumerable, IEnumerator {

protected override EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord GetElementDefaultValue() {
return new EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord();
}

public T[] ToArray<T>(Func<EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4c958626af795efca6e20049d3d8be72 recordList, Func<EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4c958626af795efca6e20049d3d8be72(EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord[] array) {
  RL_4c958626af795efca6e20049d3d8be72 result = new RL_4c958626af795efca6e20049d3d8be72();
result.InnerFromArray(array);
    return result;
}

public static RL_4c958626af795efca6e20049d3d8be72 ToList<T>(T[] array, Func <T, EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord> converter) {
  RL_4c958626af795efca6e20049d3d8be72 result = new RL_4c958626af795efca6e20049d3d8be72();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4c958626af795efca6e20049d3d8be72 FromRestList<T>(RestList<T> restList, Func <T, EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord> converter) {
  RL_4c958626af795efca6e20049d3d8be72 result = new RL_4c958626af795efca6e20049d3d8be72();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4c958626af795efca6e20049d3d8be72() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord> NewList() {
return new RL_4c958626af795efca6e20049d3d8be72();
}


} // RL_4c958626af795efca6e20049d3d8be72
}
