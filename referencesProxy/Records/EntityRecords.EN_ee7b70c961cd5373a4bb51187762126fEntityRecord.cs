using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] PurchasingGroup (ky4jsWHGgk2AujY+XPnMuQ)
///  <code>EN_ee7b70c961cd5373a4bb51187762126fEntityRecord</code> that represent
/// s <code>PurchasingGroup</code> <p>Description: Grupo de compras</p>
/// </summary>
// Name: PurchasingGroup
public partial struct EN_ee7b70c961cd5373a4bb51187762126fEntityRecord : ITypedRecord<EN_ee7b70c961cd5373a4bb51187762126fEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*Xu64cGu+60Cf6atvne+hvg");
internal static readonly GlobalObjectKey IdMd = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*zYdHwduGEEmLlXDORnWvHw");
internal static readonly GlobalObjectKey IdCode = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*De5AKBGZsky8OojXW_Sb_Q");
internal static readonly GlobalObjectKey IdDenomination = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*BUhtwo3nb02MTn3hE9edsw");
internal static readonly GlobalObjectKey IdUsedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*JbdvOn8b8Ea_5pcDXc5iTA");
internal static readonly GlobalObjectKey IdRegionId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*cWwhp7qbikWe_9KO+1yDQw");
internal static readonly GlobalObjectKey IdNotes = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*8ET67GZ0sUikASG35QCScg");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*RUQClzUnC0iSttAhjHhXlA");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*M1MmrYTPgkOPpjo8tumUqQ");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*zlrrEwEB_06LT+Jg49pxmg");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*U06Y2ew57UG7Bn5oz8WkTw");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(11,true);
          _ssId = value;
      }
  }
}

private string _ssMd;
public string ssMd{
  get{
      return _ssMd;
  }
  set{
      if((_ssMd!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssMd = value;
      }
  }
}

private string _ssCode;
public string ssCode{
  get{
      return _ssCode;
  }
  set{
      if((_ssCode!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssCode = value;
      }
  }
}

private string _ssDenomination;
public string ssDenomination{
  get{
      return _ssDenomination;
  }
  set{
      if((_ssDenomination!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssDenomination = value;
      }
  }
}

private string _ssUsedOn;
public string ssUsedOn{
  get{
      return _ssUsedOn;
  }
  set{
      if((_ssUsedOn!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssUsedOn = value;
      }
  }
}

private long _ssRegionId;
public long ssRegionId{
  get{
      return _ssRegionId;
  }
  set{
      if((_ssRegionId!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssRegionId = value;
      }
  }
}

private string _ssNotes;
public string ssNotes{
  get{
      return _ssNotes;
  }
  set{
      if((_ssNotes!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssNotes = value;
      }
  }
}

private DateTime _ssCreatedOn;
public DateTime ssCreatedOn{
  get{
      return _ssCreatedOn;
  }
  set{
      if((_ssCreatedOn!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
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
      if((_ssCreatedBy!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
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
      if((_ssUpdatedOn!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
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
      if((_ssUpdatedBy!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssUpdatedBy = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_ee7b70c961cd5373a4bb51187762126fEntityRecord() {
ChangedAttributes = new BitArray(11,true);
OptimizedAttributes = new BitArray(11,false);
_ssId = 0L;
_ssMd = "";
_ssCode = "";
_ssDenomination = "";
_ssUsedOn = "";
_ssRegionId = 0L;
_ssNotes = "";
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
ssId = r.ReadLongInteger(index++, "PurchasingGroup.Id", 0L);
ssMd = r.ReadText(index++, "PurchasingGroup.Md", "");
ssCode = r.ReadText(index++, "PurchasingGroup.Code", "");
ssDenomination = r.ReadText(index++, "PurchasingGroup.Denomination", "");
ssUsedOn = r.ReadText(index++, "PurchasingGroup.UsedOn", "");
ssRegionId = r.ReadEntityReferenceLongInteger(index++, "PurchasingGroup.RegionId", 0L);
ssNotes = r.ReadText(index++, "PurchasingGroup.Notes", "");
ssCreatedOn = r.ReadDateTime(index++, "PurchasingGroup.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCreatedBy = r.ReadEntityReferenceText(index++, "PurchasingGroup.CreatedBy", "");
ssUpdatedOn = r.ReadDateTime(index++, "PurchasingGroup.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "PurchasingGroup.UpdatedBy", "");
ChangedAttributes = new BitArray(11,false);
OptimizedAttributes = new BitArray(11,false);
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
public void ReadIM(EN_ee7b70c961cd5373a4bb51187762126fEntityRecord r) {
this = r;
}


public static bool operator == (EN_ee7b70c961cd5373a4bb51187762126fEntityRecord a, EN_ee7b70c961cd5373a4bb51187762126fEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssMd != b.ssMd) return false;
if (a.ssCode != b.ssCode) return false;
if (a.ssDenomination != b.ssDenomination) return false;
if (a.ssUsedOn != b.ssUsedOn) return false;
if (a.ssRegionId != b.ssRegionId) return false;
if (a.ssNotes != b.ssNotes) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
return true;
}

public static bool operator != (EN_ee7b70c961cd5373a4bb51187762126fEntityRecord a, EN_ee7b70c961cd5373a4bb51187762126fEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_ee7b70c961cd5373a4bb51187762126fEntityRecord)) return false;
return (this == (EN_ee7b70c961cd5373a4bb51187762126fEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssMd.GetHashCode()
 ^ ssCode.GetHashCode()
 ^ ssDenomination.GetHashCode()
 ^ ssUsedOn.GetHashCode()
 ^ ssRegionId.GetHashCode()
 ^ ssNotes.GetHashCode()
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


public EN_ee7b70c961cd5373a4bb51187762126fEntityRecord Duplicate() {
EN_ee7b70c961cd5373a4bb51187762126fEntityRecord t;
t._ssId = this._ssId;
t._ssMd = this._ssMd;
t._ssCode = this._ssCode;
t._ssDenomination = this._ssDenomination;
t._ssUsedOn = this._ssUsedOn;
t._ssRegionId = this._ssRegionId;
t._ssNotes = this._ssNotes;
t._ssCreatedOn = this._ssCreatedOn;
t._ssCreatedBy = this._ssCreatedBy;
t._ssUpdatedOn = this._ssUpdatedOn;
t._ssUpdatedBy = this._ssUpdatedBy;
t.ChangedAttributes = new BitArray(11);
t.OptimizedAttributes = new BitArray(11);
for(int i = 0; i < 11; i++){
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
} else if (head == "md") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Md")) variable.Value = ssMd; else variable.Optimized = true;
} else if (head == "code") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Code")) variable.Value = ssCode; else variable.Optimized = true;
} else if (head == "denomination") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Denomination")) variable.Value = ssDenomination; else variable.Optimized = true;
} else if (head == "usedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UsedOn")) variable.Value = ssUsedOn; else variable.Optimized = true;
} else if (head == "regionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RegionId")) variable.Value = ssRegionId; else variable.Optimized = true;
} else if (head == "notes") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Notes")) variable.Value = ssNotes; else variable.Optimized = true;
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
if (key.Equals(IdMd)) {
return ChangedAttributes[1];
}
if (key.Equals(IdCode)) {
return ChangedAttributes[2];
}
if (key.Equals(IdDenomination)) {
return ChangedAttributes[3];
}
if (key.Equals(IdUsedOn)) {
return ChangedAttributes[4];
}
if (key.Equals(IdRegionId)) {
return ChangedAttributes[5];
}
if (key.Equals(IdNotes)) {
return ChangedAttributes[6];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[7];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[8];
}
if (key.Equals(IdUpdatedOn)) {
return ChangedAttributes[9];
}
if (key.Equals(IdUpdatedBy)) {
return ChangedAttributes[10];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdMd)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdCode)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdDenomination)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdUsedOn)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdRegionId)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdNotes)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdUpdatedOn)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdUpdatedBy)) {
return OptimizedAttributes[10];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdMd) {
return ssMd;
}
if (key == IdCode) {
return ssCode;
}
if (key == IdDenomination) {
return ssDenomination;
}
if (key == IdUsedOn) {
return ssUsedOn;
}
if (key == IdRegionId) {
return ssRegionId;
}
if (key == IdNotes) {
return ssNotes;
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
if (attributeKey == IdMd.Key.AsGuid) {
return ssMd;
}
if (attributeKey == IdCode.Key.AsGuid) {
return ssCode;
}
if (attributeKey == IdDenomination.Key.AsGuid) {
return ssDenomination;
}
if (attributeKey == IdUsedOn.Key.AsGuid) {
return ssUsedOn;
}
if (attributeKey == IdRegionId.Key.AsGuid) {
return ssRegionId;
}
if (attributeKey == IdNotes.Key.AsGuid) {
return ssNotes;
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
ChangedAttributes = new BitArray(11);
OptimizedAttributes = new BitArray(11);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssMd = (string) other.AttributeGet(IdMd);
ChangedAttributes[1] = other.ChangedAttributeGet(IdMd);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdMd);
ssCode = (string) other.AttributeGet(IdCode);
ChangedAttributes[2] = other.ChangedAttributeGet(IdCode);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdCode);
ssDenomination = (string) other.AttributeGet(IdDenomination);
ChangedAttributes[3] = other.ChangedAttributeGet(IdDenomination);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdDenomination);
ssUsedOn = (string) other.AttributeGet(IdUsedOn);
ChangedAttributes[4] = other.ChangedAttributeGet(IdUsedOn);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdUsedOn);
ssRegionId = (long) other.AttributeGet(IdRegionId);
ChangedAttributes[5] = other.ChangedAttributeGet(IdRegionId);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdRegionId);
ssNotes = (string) other.AttributeGet(IdNotes);
ChangedAttributes[6] = other.ChangedAttributeGet(IdNotes);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdNotes);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[7] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdCreatedOn);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[8] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdCreatedBy);
ssUpdatedOn = (DateTime) other.AttributeGet(IdUpdatedOn);
ChangedAttributes[9] = other.ChangedAttributeGet(IdUpdatedOn);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdUpdatedOn);
ssUpdatedBy = (string) other.AttributeGet(IdUpdatedBy);
ChangedAttributes[10] = other.ChangedAttributeGet(IdUpdatedBy);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdUpdatedBy);
}
} // EN_ee7b70c961cd5373a4bb51187762126fEntityRecord

/// <summary>
/// RecordList type <code>PurchasingGroupList</code> that represents a record list of
///  <code>PurchasingGroup</code>
/// </summary>
public partial class RL_a1b0b8279a7e9747d162f871be2aa857 : GenericRecordList<EN_ee7b70c961cd5373a4bb51187762126fEntityRecord>, IEnumerable, IEnumerator {

protected override EN_ee7b70c961cd5373a4bb51187762126fEntityRecord GetElementDefaultValue() {
return new EN_ee7b70c961cd5373a4bb51187762126fEntityRecord();
}

public T[] ToArray<T>(Func<EN_ee7b70c961cd5373a4bb51187762126fEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a1b0b8279a7e9747d162f871be2aa857 recordList, Func<EN_ee7b70c961cd5373a4bb51187762126fEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a1b0b8279a7e9747d162f871be2aa857(EN_ee7b70c961cd5373a4bb51187762126fEntityRecord[] array) {
  RL_a1b0b8279a7e9747d162f871be2aa857 result = new RL_a1b0b8279a7e9747d162f871be2aa857();
result.InnerFromArray(array);
    return result;
}

public static RL_a1b0b8279a7e9747d162f871be2aa857 ToList<T>(T[] array, Func <T, EN_ee7b70c961cd5373a4bb51187762126fEntityRecord> converter) {
  RL_a1b0b8279a7e9747d162f871be2aa857 result = new RL_a1b0b8279a7e9747d162f871be2aa857();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a1b0b8279a7e9747d162f871be2aa857 FromRestList<T>(RestList<T> restList, Func <T, EN_ee7b70c961cd5373a4bb51187762126fEntityRecord> converter) {
  RL_a1b0b8279a7e9747d162f871be2aa857 result = new RL_a1b0b8279a7e9747d162f871be2aa857();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a1b0b8279a7e9747d162f871be2aa857() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_ee7b70c961cd5373a4bb51187762126fEntityRecord> NewList() {
return new RL_a1b0b8279a7e9747d162f871be2aa857();
}


} // RL_a1b0b8279a7e9747d162f871be2aa857
}
