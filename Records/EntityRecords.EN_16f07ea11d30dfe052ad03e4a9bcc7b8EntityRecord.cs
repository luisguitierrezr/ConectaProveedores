using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] PaymentWays (rjHC4aPhe0qYl0+CQ6tMZg)
///  <code>EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord</code> that represent
/// s <code>PaymentWays</code> <p>Description: Entity holds Payments Ways. Formas de Pago.</p>
/// </summary>
// Name: PaymentWays
public partial struct EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord : ITypedRecord<EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*M6Deq1il80yxsI9SFo_yOg");
internal static readonly GlobalObjectKey IdCode = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*SKSOEiWnEU+9yEJ7Y_FebA");
internal static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*RYi9TH5IrEyInFezuoknVg");
internal static readonly GlobalObjectKey IdIsActive = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*zoNpfYpqakC4oBjpCMEn8g");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*wA9V1Dm9UECt_yz+9kJSfw");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*QxodSBCI8Uy8jxp7qMkSqA");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*UX+cjaGlGUeosa9A8SEjJQ");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*gYZkfGKbgEKCQVWBESGHxw");

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

private string _ssCode;
public string ssCode{
  get{
      return _ssCode;
  }
  set{
      if((_ssCode!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssCode = value;
      }
  }
}

private string _ssDescription;
public string ssDescription{
  get{
      return _ssDescription;
  }
  set{
      if((_ssDescription!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssDescription = value;
      }
  }
}

private bool _ssIsActive;
public bool ssIsActive{
  get{
      return _ssIsActive;
  }
  set{
      if((_ssIsActive!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
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
      if((_ssCreatedOn!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
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
      if((_ssCreatedBy!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
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
      if((_ssUpdatedOn!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
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
      if((_ssUpdatedBy!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssUpdatedBy = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord() {
ChangedAttributes = new BitArray(8,true);
OptimizedAttributes = new BitArray(8,false);
_ssId = 0L;
_ssCode = "";
_ssDescription = "";
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
ssId = r.ReadLongInteger(index++, "PaymentWays.Id", 0L);
ssCode = r.ReadText(index++, "PaymentWays.Code", "");
ssDescription = r.ReadText(index++, "PaymentWays.Description", "");
ssIsActive = r.ReadBoolean(index++, "PaymentWays.IsActive", true);
ssCreatedOn = r.ReadDateTime(index++, "PaymentWays.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCreatedBy = r.ReadEntityReferenceText(index++, "PaymentWays.CreatedBy", "");
ssUpdatedOn = r.ReadDateTime(index++, "PaymentWays.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "PaymentWays.UpdatedBy", "");
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
public void ReadIM(EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord r) {
this = r;
}


public static bool operator == (EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord a, EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssCode != b.ssCode) return false;
if (a.ssDescription != b.ssDescription) return false;
if (a.ssIsActive != b.ssIsActive) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
return true;
}

public static bool operator != (EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord a, EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord)) return false;
return (this == (EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssCode.GetHashCode()
 ^ ssDescription.GetHashCode()
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


public EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord Duplicate() {
EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord t;
t._ssId = this._ssId;
t._ssCode = this._ssCode;
t._ssDescription = this._ssDescription;
t._ssIsActive = this._ssIsActive;
t._ssCreatedOn = this._ssCreatedOn;
t._ssCreatedBy = this._ssCreatedBy;
t._ssUpdatedOn = this._ssUpdatedOn;
t._ssUpdatedBy = this._ssUpdatedBy;
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
} else if (head == "code") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Code")) variable.Value = ssCode; else variable.Optimized = true;
} else if (head == "description") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
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
if (key.Equals(IdCode)) {
return ChangedAttributes[1];
}
if (key.Equals(IdDescription)) {
return ChangedAttributes[2];
}
if (key.Equals(IdIsActive)) {
return ChangedAttributes[3];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[4];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[5];
}
if (key.Equals(IdUpdatedOn)) {
return ChangedAttributes[6];
}
if (key.Equals(IdUpdatedBy)) {
return ChangedAttributes[7];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdCode)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdDescription)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdIsActive)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdUpdatedOn)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdUpdatedBy)) {
return OptimizedAttributes[7];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdCode) {
return ssCode;
}
if (key == IdDescription) {
return ssDescription;
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
if (attributeKey == IdCode.Key.AsGuid) {
return ssCode;
}
if (attributeKey == IdDescription.Key.AsGuid) {
return ssDescription;
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
ChangedAttributes = new BitArray(8);
OptimizedAttributes = new BitArray(8);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssCode = (string) other.AttributeGet(IdCode);
ChangedAttributes[1] = other.ChangedAttributeGet(IdCode);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdCode);
ssDescription = (string) other.AttributeGet(IdDescription);
ChangedAttributes[2] = other.ChangedAttributeGet(IdDescription);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdDescription);
ssIsActive = (bool) other.AttributeGet(IdIsActive);
ChangedAttributes[3] = other.ChangedAttributeGet(IdIsActive);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdIsActive);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[4] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdCreatedOn);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[5] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdCreatedBy);
ssUpdatedOn = (DateTime) other.AttributeGet(IdUpdatedOn);
ChangedAttributes[6] = other.ChangedAttributeGet(IdUpdatedOn);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdUpdatedOn);
ssUpdatedBy = (string) other.AttributeGet(IdUpdatedBy);
ChangedAttributes[7] = other.ChangedAttributeGet(IdUpdatedBy);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdUpdatedBy);
}
} // EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord

/// <summary>
/// RecordList type <code>PaymentWaysList</code> that represents a record list of
///  <code>PaymentWays</code>
/// </summary>
public partial class RL_b7651611ac4d6a0372ae45ac2e3c6a99 : GenericRecordList<EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord>, IEnumerable, IEnumerator {

protected override EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord GetElementDefaultValue() {
return new EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord();
}

public T[] ToArray<T>(Func<EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b7651611ac4d6a0372ae45ac2e3c6a99 recordList, Func<EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b7651611ac4d6a0372ae45ac2e3c6a99(EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord[] array) {
  RL_b7651611ac4d6a0372ae45ac2e3c6a99 result = new RL_b7651611ac4d6a0372ae45ac2e3c6a99();
result.InnerFromArray(array);
    return result;
}

public static RL_b7651611ac4d6a0372ae45ac2e3c6a99 ToList<T>(T[] array, Func <T, EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord> converter) {
  RL_b7651611ac4d6a0372ae45ac2e3c6a99 result = new RL_b7651611ac4d6a0372ae45ac2e3c6a99();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b7651611ac4d6a0372ae45ac2e3c6a99 FromRestList<T>(RestList<T> restList, Func <T, EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord> converter) {
  RL_b7651611ac4d6a0372ae45ac2e3c6a99 result = new RL_b7651611ac4d6a0372ae45ac2e3c6a99();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b7651611ac4d6a0372ae45ac2e3c6a99() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord> NewList() {
return new RL_b7651611ac4d6a0372ae45ac2e3c6a99();
}


} // RL_b7651611ac4d6a0372ae45ac2e3c6a99
}
