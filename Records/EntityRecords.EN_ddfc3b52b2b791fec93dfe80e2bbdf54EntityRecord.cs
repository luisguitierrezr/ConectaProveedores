using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] EntryBlockDates (PUzIWFvyZkGxz+cbFay1Qg)
///  <code>EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord</code> that represent
/// s <code>EntryBlockDates</code> <p>Description: Dates to block entries when Folio is approved</p>
/// </summary>
// Name: EntryBlockDates
public partial struct EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord : ITypedRecord<EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*zd+hjrOIqECa4f+6lNnEqg");
internal static readonly GlobalObjectKey IdInitialDate = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*1EcggPvB9Um1Ps28PkjM8Q");
internal static readonly GlobalObjectKey IdEndingDate = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*olO472cB70Gsa3leNoC1Ig");
internal static readonly GlobalObjectKey IdImputationCode = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*+zrCCGIdOkiD0l2_315+8Q");
internal static readonly GlobalObjectKey IdGLAccountsId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*SKymBN_afEympOyNYscjMw");
internal static readonly GlobalObjectKey IdIsActive = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*_ChS9Pe7FEmlHCGuY271VQ");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*gBjcdEcdOUS36K7VM4wLsw");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*ANbiJe6CIUuIr9MSyclONg");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*kIi9waaoekusTHCjeYj0_Q");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*3ET_fbG+KkCdkCKIZFgbfw");

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

private DateTime _ssInitialDate;
public DateTime ssInitialDate{
  get{
      return _ssInitialDate;
  }
  set{
      if((_ssInitialDate!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssInitialDate = value;
      }
  }
}

private DateTime _ssEndingDate;
public DateTime ssEndingDate{
  get{
      return _ssEndingDate;
  }
  set{
      if((_ssEndingDate!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssEndingDate = value;
      }
  }
}

private string _ssImputationCode;
public string ssImputationCode{
  get{
      return _ssImputationCode;
  }
  set{
      if((_ssImputationCode!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssImputationCode = value;
      }
  }
}

private long _ssGLAccountsId;
public long ssGLAccountsId{
  get{
      return _ssGLAccountsId;
  }
  set{
      if((_ssGLAccountsId!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssGLAccountsId = value;
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

public EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord() {
ChangedAttributes = new BitArray(10,true);
OptimizedAttributes = new BitArray(10,false);
_ssId = 0L;
_ssInitialDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssEndingDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssImputationCode = "";
_ssGLAccountsId = 0L;
_ssIsActive = false;
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
ssId = r.ReadLongInteger(index++, "EntryBlockDates.Id", 0L);
ssInitialDate = r.ReadDate(index++, "EntryBlockDates.InitialDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssEndingDate = r.ReadDate(index++, "EntryBlockDates.EndingDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssImputationCode = r.ReadText(index++, "EntryBlockDates.ImputationCode", "");
ssGLAccountsId = r.ReadEntityReferenceLongInteger(index++, "EntryBlockDates.GLAccountsId", 0L);
ssIsActive = r.ReadBoolean(index++, "EntryBlockDates.IsActive", false);
ssCreatedOn = r.ReadDateTime(index++, "EntryBlockDates.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCreatedBy = r.ReadEntityReferenceText(index++, "EntryBlockDates.CreatedBy", "");
ssUpdatedOn = r.ReadDateTime(index++, "EntryBlockDates.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "EntryBlockDates.UpdatedBy", "");
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
public void ReadIM(EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord r) {
this = r;
}


public static bool operator == (EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord a, EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssInitialDate != b.ssInitialDate) return false;
if (a.ssEndingDate != b.ssEndingDate) return false;
if (a.ssImputationCode != b.ssImputationCode) return false;
if (a.ssGLAccountsId != b.ssGLAccountsId) return false;
if (a.ssIsActive != b.ssIsActive) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
return true;
}

public static bool operator != (EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord a, EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord)) return false;
return (this == (EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssInitialDate.GetHashCode()
 ^ ssEndingDate.GetHashCode()
 ^ ssImputationCode.GetHashCode()
 ^ ssGLAccountsId.GetHashCode()
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


public EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord Duplicate() {
EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord t;
t._ssId = this._ssId;
t._ssInitialDate = this._ssInitialDate;
t._ssEndingDate = this._ssEndingDate;
t._ssImputationCode = this._ssImputationCode;
t._ssGLAccountsId = this._ssGLAccountsId;
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
} else if (head == "initialdate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InitialDate")) variable.Value = ssInitialDate; else variable.Optimized = true;
} else if (head == "endingdate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EndingDate")) variable.Value = ssEndingDate; else variable.Optimized = true;
} else if (head == "imputationcode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ImputationCode")) variable.Value = ssImputationCode; else variable.Optimized = true;
} else if (head == "glaccountsid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".GLAccountsId")) variable.Value = ssGLAccountsId; else variable.Optimized = true;
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
if (key.Equals(IdInitialDate)) {
return ChangedAttributes[1];
}
if (key.Equals(IdEndingDate)) {
return ChangedAttributes[2];
}
if (key.Equals(IdImputationCode)) {
return ChangedAttributes[3];
}
if (key.Equals(IdGLAccountsId)) {
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
if (key.Equals(IdInitialDate)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdEndingDate)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdImputationCode)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdGLAccountsId)) {
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
if (key == IdInitialDate) {
return ssInitialDate;
}
if (key == IdEndingDate) {
return ssEndingDate;
}
if (key == IdImputationCode) {
return ssImputationCode;
}
if (key == IdGLAccountsId) {
return ssGLAccountsId;
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
if (attributeKey == IdInitialDate.Key.AsGuid) {
return ssInitialDate;
}
if (attributeKey == IdEndingDate.Key.AsGuid) {
return ssEndingDate;
}
if (attributeKey == IdImputationCode.Key.AsGuid) {
return ssImputationCode;
}
if (attributeKey == IdGLAccountsId.Key.AsGuid) {
return ssGLAccountsId;
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
ssInitialDate = (DateTime) other.AttributeGet(IdInitialDate);
ChangedAttributes[1] = other.ChangedAttributeGet(IdInitialDate);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdInitialDate);
ssEndingDate = (DateTime) other.AttributeGet(IdEndingDate);
ChangedAttributes[2] = other.ChangedAttributeGet(IdEndingDate);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdEndingDate);
ssImputationCode = (string) other.AttributeGet(IdImputationCode);
ChangedAttributes[3] = other.ChangedAttributeGet(IdImputationCode);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdImputationCode);
ssGLAccountsId = (long) other.AttributeGet(IdGLAccountsId);
ChangedAttributes[4] = other.ChangedAttributeGet(IdGLAccountsId);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdGLAccountsId);
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
} // EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord

/// <summary>
/// RecordList type <code>EntryBlockDatesList</code> that represents a record list of
///  <code>EntryBlockDates</code>
/// </summary>
public partial class RL_f7d9f52f92482f9a14939776c951f292 : GenericRecordList<EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord>, IEnumerable, IEnumerator {

protected override EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord GetElementDefaultValue() {
return new EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord();
}

public T[] ToArray<T>(Func<EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f7d9f52f92482f9a14939776c951f292 recordList, Func<EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f7d9f52f92482f9a14939776c951f292(EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord[] array) {
  RL_f7d9f52f92482f9a14939776c951f292 result = new RL_f7d9f52f92482f9a14939776c951f292();
result.InnerFromArray(array);
    return result;
}

public static RL_f7d9f52f92482f9a14939776c951f292 ToList<T>(T[] array, Func <T, EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord> converter) {
  RL_f7d9f52f92482f9a14939776c951f292 result = new RL_f7d9f52f92482f9a14939776c951f292();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f7d9f52f92482f9a14939776c951f292 FromRestList<T>(RestList<T> restList, Func <T, EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord> converter) {
  RL_f7d9f52f92482f9a14939776c951f292 result = new RL_f7d9f52f92482f9a14939776c951f292();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f7d9f52f92482f9a14939776c951f292() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord> NewList() {
return new RL_f7d9f52f92482f9a14939776c951f292();
}


} // RL_f7d9f52f92482f9a14939776c951f292
}
