using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] InvoiceUsage (V3Q89cKft0ek7ZnO9piD4Q)
///  <code>EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord</code> that represent
/// s <code>InvoiceUsage</code> <p>Description: Entity holds invoices usage.</p>
/// </summary>
// Name: InvoiceUsage
public partial struct EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord : ITypedRecord<EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*W_wOb_ylmkaMSQqhuQKSHw");
internal static readonly GlobalObjectKey IdKey = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*b7C7Ls+pY0GgFpGiCkctVA");
internal static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*vyhSLby9RE6t9mliLNaiBQ");
internal static readonly GlobalObjectKey IdIsAppliedToObjectivePerson = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*AhLA_uB9ckaEBpg3zPY81w");
internal static readonly GlobalObjectKey IdIsAppliedToMoralPerson = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*E5ypILoNT0yWTHGWG1PTuw");
internal static readonly GlobalObjectKey IdIsActive = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*wgaB8jMP_06EvRSR0Y2DmQ");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*xKT_qEvF50e1VrX8GpP3vw");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*LKZbk25lgkiYjlNOCtBZUQ");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*42OfOPGN+EGoT+Bdi7K4Sw");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*TdThzqmNSUa4UjBiWwQY8g");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(10,true);
          _ssId = value;
      }
  }
}

private string _ssKey;
public string ssKey{
  get{
      return _ssKey;
  }
  set{
      if((_ssKey!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssKey = value;
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

private bool _ssIsAppliedToObjectivePerson;
public bool ssIsAppliedToObjectivePerson{
  get{
      return _ssIsAppliedToObjectivePerson;
  }
  set{
      if((_ssIsAppliedToObjectivePerson!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssIsAppliedToObjectivePerson = value;
      }
  }
}

private bool _ssIsAppliedToMoralPerson;
public bool ssIsAppliedToMoralPerson{
  get{
      return _ssIsAppliedToMoralPerson;
  }
  set{
      if((_ssIsAppliedToMoralPerson!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssIsAppliedToMoralPerson = value;
      }
  }
}

private bool _ssIsActive;
public bool ssIsActive{
  get{
      return _ssIsActive;
  }
  set{
      if((_ssIsActive!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
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
      if((_ssCreatedOn!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
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
      if((_ssCreatedBy!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
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
      if((_ssUpdatedOn!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
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
      if((_ssUpdatedBy!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssUpdatedBy = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord() {
ChangedAttributes = new BitArray(10,true);
OptimizedAttributes = new BitArray(10,false);
_ssId = 0L;
_ssKey = "";
_ssDescription = "";
_ssIsAppliedToObjectivePerson = false;
_ssIsAppliedToMoralPerson = false;
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
ssId = r.ReadLongInteger(index++, "InvoiceUsage.Id", 0L);
ssKey = r.ReadText(index++, "InvoiceUsage.Key", "");
ssDescription = r.ReadText(index++, "InvoiceUsage.Description", "");
ssIsAppliedToObjectivePerson = r.ReadBoolean(index++, "InvoiceUsage.IsAppliedToObjectivePerson", false);
ssIsAppliedToMoralPerson = r.ReadBoolean(index++, "InvoiceUsage.IsAppliedToMoralPerson", false);
ssIsActive = r.ReadBoolean(index++, "InvoiceUsage.IsActive", true);
ssCreatedOn = r.ReadDateTime(index++, "InvoiceUsage.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCreatedBy = r.ReadEntityReferenceText(index++, "InvoiceUsage.CreatedBy", "");
ssUpdatedOn = r.ReadDateTime(index++, "InvoiceUsage.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "InvoiceUsage.UpdatedBy", "");
ChangedAttributes = new BitArray(10,false);
OptimizedAttributes = new BitArray(10,false);
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
public void ReadIM(EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord r) {
this = r;
}


public static bool operator == (EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord a, EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssKey != b.ssKey) return false;
if (a.ssDescription != b.ssDescription) return false;
if (a.ssIsAppliedToObjectivePerson != b.ssIsAppliedToObjectivePerson) return false;
if (a.ssIsAppliedToMoralPerson != b.ssIsAppliedToMoralPerson) return false;
if (a.ssIsActive != b.ssIsActive) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
return true;
}

public static bool operator != (EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord a, EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord)) return false;
return (this == (EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssKey.GetHashCode()
 ^ ssDescription.GetHashCode()
 ^ ssIsAppliedToObjectivePerson.GetHashCode()
 ^ ssIsAppliedToMoralPerson.GetHashCode()
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


public EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord Duplicate() {
EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord t;
t._ssId = this._ssId;
t._ssKey = this._ssKey;
t._ssDescription = this._ssDescription;
t._ssIsAppliedToObjectivePerson = this._ssIsAppliedToObjectivePerson;
t._ssIsAppliedToMoralPerson = this._ssIsAppliedToMoralPerson;
t._ssIsActive = this._ssIsActive;
t._ssCreatedOn = this._ssCreatedOn;
t._ssCreatedBy = this._ssCreatedBy;
t._ssUpdatedOn = this._ssUpdatedOn;
t._ssUpdatedBy = this._ssUpdatedBy;
t.ChangedAttributes = new BitArray(10);
t.OptimizedAttributes = new BitArray(10);
for(int i = 0; i < 10; i++){
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
} else if (head == "key") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Key")) variable.Value = ssKey; else variable.Optimized = true;
} else if (head == "description") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
} else if (head == "isappliedtoobjectiveperson") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsAppliedToObjectivePerson")) variable.Value = ssIsAppliedToObjectivePerson; else variable.Optimized = true;
} else if (head == "isappliedtomoralperson") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsAppliedToMoralPerson")) variable.Value = ssIsAppliedToMoralPerson; else variable.Optimized = true;
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
if (key.Equals(IdKey)) {
return ChangedAttributes[1];
}
if (key.Equals(IdDescription)) {
return ChangedAttributes[2];
}
if (key.Equals(IdIsAppliedToObjectivePerson)) {
return ChangedAttributes[3];
}
if (key.Equals(IdIsAppliedToMoralPerson)) {
return ChangedAttributes[4];
}
if (key.Equals(IdIsActive)) {
return ChangedAttributes[5];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[6];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[7];
}
if (key.Equals(IdUpdatedOn)) {
return ChangedAttributes[8];
}
if (key.Equals(IdUpdatedBy)) {
return ChangedAttributes[9];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdKey)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdDescription)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdIsAppliedToObjectivePerson)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdIsAppliedToMoralPerson)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdIsActive)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdUpdatedOn)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdUpdatedBy)) {
return OptimizedAttributes[9];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdKey) {
return ssKey;
}
if (key == IdDescription) {
return ssDescription;
}
if (key == IdIsAppliedToObjectivePerson) {
return ssIsAppliedToObjectivePerson;
}
if (key == IdIsAppliedToMoralPerson) {
return ssIsAppliedToMoralPerson;
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
if (attributeKey == IdKey.Key.AsGuid) {
return ssKey;
}
if (attributeKey == IdDescription.Key.AsGuid) {
return ssDescription;
}
if (attributeKey == IdIsAppliedToObjectivePerson.Key.AsGuid) {
return ssIsAppliedToObjectivePerson;
}
if (attributeKey == IdIsAppliedToMoralPerson.Key.AsGuid) {
return ssIsAppliedToMoralPerson;
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
ChangedAttributes = new BitArray(10);
OptimizedAttributes = new BitArray(10);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssKey = (string) other.AttributeGet(IdKey);
ChangedAttributes[1] = other.ChangedAttributeGet(IdKey);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdKey);
ssDescription = (string) other.AttributeGet(IdDescription);
ChangedAttributes[2] = other.ChangedAttributeGet(IdDescription);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdDescription);
ssIsAppliedToObjectivePerson = (bool) other.AttributeGet(IdIsAppliedToObjectivePerson);
ChangedAttributes[3] = other.ChangedAttributeGet(IdIsAppliedToObjectivePerson);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdIsAppliedToObjectivePerson);
ssIsAppliedToMoralPerson = (bool) other.AttributeGet(IdIsAppliedToMoralPerson);
ChangedAttributes[4] = other.ChangedAttributeGet(IdIsAppliedToMoralPerson);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdIsAppliedToMoralPerson);
ssIsActive = (bool) other.AttributeGet(IdIsActive);
ChangedAttributes[5] = other.ChangedAttributeGet(IdIsActive);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdIsActive);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[6] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdCreatedOn);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[7] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdCreatedBy);
ssUpdatedOn = (DateTime) other.AttributeGet(IdUpdatedOn);
ChangedAttributes[8] = other.ChangedAttributeGet(IdUpdatedOn);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdUpdatedOn);
ssUpdatedBy = (string) other.AttributeGet(IdUpdatedBy);
ChangedAttributes[9] = other.ChangedAttributeGet(IdUpdatedBy);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdUpdatedBy);
}
} // EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord

/// <summary>
/// RecordList type <code>InvoiceUsageList</code> that represents a record list of
///  <code>InvoiceUsage</code>
/// </summary>
public partial class RL_ff3c541bf0b46b936524e61263580f65 : GenericRecordList<EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord>, IEnumerable, IEnumerator {

protected override EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord GetElementDefaultValue() {
return new EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord();
}

public T[] ToArray<T>(Func<EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ff3c541bf0b46b936524e61263580f65 recordList, Func<EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ff3c541bf0b46b936524e61263580f65(EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord[] array) {
  RL_ff3c541bf0b46b936524e61263580f65 result = new RL_ff3c541bf0b46b936524e61263580f65();
result.InnerFromArray(array);
    return result;
}

public static RL_ff3c541bf0b46b936524e61263580f65 ToList<T>(T[] array, Func <T, EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord> converter) {
  RL_ff3c541bf0b46b936524e61263580f65 result = new RL_ff3c541bf0b46b936524e61263580f65();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ff3c541bf0b46b936524e61263580f65 FromRestList<T>(RestList<T> restList, Func <T, EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord> converter) {
  RL_ff3c541bf0b46b936524e61263580f65 result = new RL_ff3c541bf0b46b936524e61263580f65();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ff3c541bf0b46b936524e61263580f65() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord> NewList() {
return new RL_ff3c541bf0b46b936524e61263580f65();
}


} // RL_ff3c541bf0b46b936524e61263580f65
}
