using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] UserExtension (zdaweVWbV0KnBA3btljsoA)
///  <code>EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord</code> that represent
/// s <code>UserExtension</code> <p>Description: User Extension</p>
/// </summary>
// Name: UserExtension
public partial struct EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord : ITypedRecord<EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("EW68qyyQGUOHi50P7GQeYQ*7vantZKhF0GbybOYeedkmQ");
internal static readonly GlobalObjectKey IdCorrespondentExternalEmail = GlobalObjectKey.Parse("EW68qyyQGUOHi50P7GQeYQ*u_fflb6RZ06LWMRuCRcZ_w");
internal static readonly GlobalObjectKey IdEmailto = GlobalObjectKey.Parse("EW68qyyQGUOHi50P7GQeYQ*ym2zZPmu3Ue6VhxN8BX7dw");

private string _ssId;
public string ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(3,true);
          _ssId = value;
      }
  }
}

private string _ssCorrespondentExternalEmail;
public string ssCorrespondentExternalEmail{
  get{
      return _ssCorrespondentExternalEmail;
  }
  set{
      if((_ssCorrespondentExternalEmail!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssCorrespondentExternalEmail = value;
      }
  }
}

private string _ssEmailto;
public string ssEmailto{
  get{
      return _ssEmailto;
  }
  set{
      if((_ssEmailto!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssEmailto = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord() {
ChangedAttributes = new BitArray(3,true);
OptimizedAttributes = new BitArray(3,false);
_ssId = "";
_ssCorrespondentExternalEmail = "";
_ssEmailto = "";
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
ssId = r.ReadEntityReferenceText(index++, "UserExtension.Id", "");
ssCorrespondentExternalEmail = r.ReadEmail(index++, "UserExtension.CorrespondentExternalEmail", "");
ssEmailto = r.ReadEmail(index++, "UserExtension.Emailto", "");
ChangedAttributes = new BitArray(3,false);
OptimizedAttributes = new BitArray(3,false);
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
public void ReadIM(EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord r) {
this = r;
}


public static bool operator == (EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord a, EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssCorrespondentExternalEmail != b.ssCorrespondentExternalEmail) return false;
if (a.ssEmailto != b.ssEmailto) return false;
return true;
}

public static bool operator != (EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord a, EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord)) return false;
return (this == (EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssCorrespondentExternalEmail.GetHashCode()
 ^ ssEmailto.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord Duplicate() {
EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord t;
t._ssId = this._ssId;
t._ssCorrespondentExternalEmail = this._ssCorrespondentExternalEmail;
t._ssEmailto = this._ssEmailto;
t.ChangedAttributes = new BitArray(3);
t.OptimizedAttributes = new BitArray(3);
for(int i = 0; i < 3; i++){
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
} else if (head == "correspondentexternalemail") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CorrespondentExternalEmail")) variable.Value = ssCorrespondentExternalEmail; else variable.Optimized = true;
} else if (head == "emailto") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Emailto")) variable.Value = ssEmailto; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdCorrespondentExternalEmail)) {
return ChangedAttributes[1];
}
if (key.Equals(IdEmailto)) {
return ChangedAttributes[2];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdCorrespondentExternalEmail)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdEmailto)) {
return OptimizedAttributes[2];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdCorrespondentExternalEmail) {
return ssCorrespondentExternalEmail;
}
if (key == IdEmailto) {
return ssEmailto;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdCorrespondentExternalEmail.Key.AsGuid) {
return ssCorrespondentExternalEmail;
}
if (attributeKey == IdEmailto.Key.AsGuid) {
return ssEmailto;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(3);
OptimizedAttributes = new BitArray(3);
if (other == null) return;
ssId = (string) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssCorrespondentExternalEmail = (string) other.AttributeGet(IdCorrespondentExternalEmail);
ChangedAttributes[1] = other.ChangedAttributeGet(IdCorrespondentExternalEmail);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdCorrespondentExternalEmail);
ssEmailto = (string) other.AttributeGet(IdEmailto);
ChangedAttributes[2] = other.ChangedAttributeGet(IdEmailto);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdEmailto);
}
} // EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord

/// <summary>
/// RecordList type <code>UserExtensionList</code> that represents a record list of
///  <code>UserExtension</code>
/// </summary>
public partial class RL_fcff58490d68fb10be1183950da4127a : GenericRecordList<EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord>, IEnumerable, IEnumerator {

protected override EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord GetElementDefaultValue() {
return new EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord();
}

public T[] ToArray<T>(Func<EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_fcff58490d68fb10be1183950da4127a recordList, Func<EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_fcff58490d68fb10be1183950da4127a(EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord[] array) {
  RL_fcff58490d68fb10be1183950da4127a result = new RL_fcff58490d68fb10be1183950da4127a();
result.InnerFromArray(array);
    return result;
}

public static RL_fcff58490d68fb10be1183950da4127a ToList<T>(T[] array, Func <T, EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord> converter) {
  RL_fcff58490d68fb10be1183950da4127a result = new RL_fcff58490d68fb10be1183950da4127a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_fcff58490d68fb10be1183950da4127a FromRestList<T>(RestList<T> restList, Func <T, EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord> converter) {
  RL_fcff58490d68fb10be1183950da4127a result = new RL_fcff58490d68fb10be1183950da4127a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_fcff58490d68fb10be1183950da4127a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord> NewList() {
return new RL_fcff58490d68fb10be1183950da4127a();
}


} // RL_fcff58490d68fb10be1183950da4127a
}
