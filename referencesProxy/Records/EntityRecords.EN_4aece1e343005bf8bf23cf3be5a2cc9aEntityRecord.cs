using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] PaymentMethods (iOheS1JOF0uLd6SePZ4zNQ)
///  <code>EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord</code> that represent
/// s <code>PaymentMethods</code> <p>Description: Entity holds Payment Methods. Metodos de Pago.</p>
/// </summary>
// Name: PaymentMethods
public partial struct EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord : ITypedRecord<EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*gF+NHMOBHEmann1cj6ZahQ");
internal static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*z+_wuqcxMEOofMa42AZ0XA");
internal static readonly GlobalObjectKey IdExternalId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*tssuZVg4h0atTsrdnigyag");
internal static readonly GlobalObjectKey IdIsFCP = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*AG3_XTgreUCEBZE6B0TnXQ");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*t_10feC7a0+sw6mAVVCn7Q");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*CYdyRz6H4kuO+9Tg+u9ySQ");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*A38MlK3vyUy42KgpZ1jEcg");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*2519H9oa4kirtAFHaHPiHQ");
internal static readonly GlobalObjectKey IdIsActive = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*ns+ROKpPM0q5HkvJ+SAJYA");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(9,true);
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

private string _ssExternalId;
public string ssExternalId{
  get{
      return _ssExternalId;
  }
  set{
      if((_ssExternalId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssExternalId = value;
      }
  }
}

private bool _ssIsFCP;
public bool ssIsFCP{
  get{
      return _ssIsFCP;
  }
  set{
      if((_ssIsFCP!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssIsFCP = value;
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

private bool _ssIsActive;
public bool ssIsActive{
  get{
      return _ssIsActive;
  }
  set{
      if((_ssIsActive!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssIsActive = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord() {
ChangedAttributes = new BitArray(9,true);
OptimizedAttributes = new BitArray(9,false);
_ssId = 0L;
_ssDescription = "";
_ssExternalId = "";
_ssIsFCP = false;
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
ssId = r.ReadLongInteger(index++, "PaymentMethods.Id", 0L);
ssDescription = r.ReadText(index++, "PaymentMethods.Description", "");
ssExternalId = r.ReadText(index++, "PaymentMethods.ExternalId", "");
ssIsFCP = r.ReadBoolean(index++, "PaymentMethods.IsFCP", false);
ssCreatedOn = r.ReadDateTime(index++, "PaymentMethods.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCreatedBy = r.ReadEntityReferenceText(index++, "PaymentMethods.CreatedBy", "");
ssUpdatedOn = r.ReadDateTime(index++, "PaymentMethods.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "PaymentMethods.UpdatedBy", "");
ssIsActive = r.ReadBoolean(index++, "PaymentMethods.IsActive", true);
ChangedAttributes = new BitArray(9,false);
OptimizedAttributes = new BitArray(9,false);
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
public void ReadIM(EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord r) {
this = r;
}


public static bool operator == (EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord a, EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssDescription != b.ssDescription) return false;
if (a.ssExternalId != b.ssExternalId) return false;
if (a.ssIsFCP != b.ssIsFCP) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
if (a.ssIsActive != b.ssIsActive) return false;
return true;
}

public static bool operator != (EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord a, EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord)) return false;
return (this == (EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssDescription.GetHashCode()
 ^ ssExternalId.GetHashCode()
 ^ ssIsFCP.GetHashCode()
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


public EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord Duplicate() {
EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord t;
t._ssId = this._ssId;
t._ssDescription = this._ssDescription;
t._ssExternalId = this._ssExternalId;
t._ssIsFCP = this._ssIsFCP;
t._ssCreatedOn = this._ssCreatedOn;
t._ssCreatedBy = this._ssCreatedBy;
t._ssUpdatedOn = this._ssUpdatedOn;
t._ssUpdatedBy = this._ssUpdatedBy;
t._ssIsActive = this._ssIsActive;
t.ChangedAttributes = new BitArray(9);
t.OptimizedAttributes = new BitArray(9);
for(int i = 0; i < 9; i++){
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
} else if (head == "externalid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExternalId")) variable.Value = ssExternalId; else variable.Optimized = true;
} else if (head == "isfcp") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsFCP")) variable.Value = ssIsFCP; else variable.Optimized = true;
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
if (key.Equals(IdExternalId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdIsFCP)) {
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
if (key.Equals(IdIsActive)) {
return ChangedAttributes[8];
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
if (key.Equals(IdExternalId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdIsFCP)) {
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
if (key.Equals(IdIsActive)) {
return OptimizedAttributes[8];
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
if (key == IdExternalId) {
return ssExternalId;
}
if (key == IdIsFCP) {
return ssIsFCP;
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
if (attributeKey == IdExternalId.Key.AsGuid) {
return ssExternalId;
}
if (attributeKey == IdIsFCP.Key.AsGuid) {
return ssIsFCP;
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
ChangedAttributes = new BitArray(9);
OptimizedAttributes = new BitArray(9);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssDescription = (string) other.AttributeGet(IdDescription);
ChangedAttributes[1] = other.ChangedAttributeGet(IdDescription);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdDescription);
ssExternalId = (string) other.AttributeGet(IdExternalId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdExternalId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdExternalId);
ssIsFCP = (bool) other.AttributeGet(IdIsFCP);
ChangedAttributes[3] = other.ChangedAttributeGet(IdIsFCP);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdIsFCP);
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
ssIsActive = (bool) other.AttributeGet(IdIsActive);
ChangedAttributes[8] = other.ChangedAttributeGet(IdIsActive);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdIsActive);
}
} // EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord

/// <summary>
/// RecordList type <code>PaymentMethodsList</code> that represents a record list of
///  <code>PaymentMethods</code>
/// </summary>
public partial class RL_58f754227b79b8198980a29045fa5b11 : GenericRecordList<EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord>, IEnumerable, IEnumerator {

protected override EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord GetElementDefaultValue() {
return new EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord();
}

public T[] ToArray<T>(Func<EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_58f754227b79b8198980a29045fa5b11 recordList, Func<EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_58f754227b79b8198980a29045fa5b11(EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord[] array) {
  RL_58f754227b79b8198980a29045fa5b11 result = new RL_58f754227b79b8198980a29045fa5b11();
result.InnerFromArray(array);
    return result;
}

public static RL_58f754227b79b8198980a29045fa5b11 ToList<T>(T[] array, Func <T, EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord> converter) {
  RL_58f754227b79b8198980a29045fa5b11 result = new RL_58f754227b79b8198980a29045fa5b11();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_58f754227b79b8198980a29045fa5b11 FromRestList<T>(RestList<T> restList, Func <T, EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord> converter) {
  RL_58f754227b79b8198980a29045fa5b11 result = new RL_58f754227b79b8198980a29045fa5b11();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_58f754227b79b8198980a29045fa5b11() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord> NewList() {
return new RL_58f754227b79b8198980a29045fa5b11();
}


} // RL_58f754227b79b8198980a29045fa5b11
}
