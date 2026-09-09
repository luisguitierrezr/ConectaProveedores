using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] Project_Asset_Service (HRPHgwqzckKpAbbPtRHGIA)
///  <code>EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord</code> that represent
/// s <code>Project_Asset_Service</code> <p>Description: Entity holds projects.</p>
/// </summary>
// Name: Project_Asset_Service
public partial struct EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord : ITypedRecord<EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*pUTqOyFZakut2znEzbpZjw");
internal static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*FwxBS_SvdUO4sCv5bdXlwg");
internal static readonly GlobalObjectKey IdIsOthers = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*6fUzF8VY3kih0LnvVNXDVw");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*h8nnWfUlG06S0ndTUKawIQ");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*hwGzImd3_Uafy08St2sClw");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*CjwOx20zkEOGWz7t3+YW8w");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*G_+U9KqEE0+J_RSeOWD1KA");

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

private bool _ssIsOthers;
public bool ssIsOthers{
  get{
      return _ssIsOthers;
  }
  set{
      if((_ssIsOthers!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssIsOthers = value;
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

public EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord() {
ChangedAttributes = new BitArray(7,true);
OptimizedAttributes = new BitArray(7,false);
_ssId = 0L;
_ssDescription = "";
_ssIsOthers = false;
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
ssId = r.ReadLongInteger(index++, "Project_Asset_Service.Id", 0L);
ssDescription = r.ReadText(index++, "Project_Asset_Service.Description", "");
ssIsOthers = r.ReadBoolean(index++, "Project_Asset_Service.IsOthers", false);
ssCreatedOn = r.ReadDateTime(index++, "Project_Asset_Service.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCreatedBy = r.ReadEntityReferenceText(index++, "Project_Asset_Service.CreatedBy", "");
ssUpdatedOn = r.ReadDateTime(index++, "Project_Asset_Service.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "Project_Asset_Service.UpdatedBy", "");
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
public void ReadIM(EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord r) {
this = r;
}


public static bool operator == (EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord a, EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssDescription != b.ssDescription) return false;
if (a.ssIsOthers != b.ssIsOthers) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
return true;
}

public static bool operator != (EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord a, EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord)) return false;
return (this == (EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssDescription.GetHashCode()
 ^ ssIsOthers.GetHashCode()
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


public EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord Duplicate() {
EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord t;
t._ssId = this._ssId;
t._ssDescription = this._ssDescription;
t._ssIsOthers = this._ssIsOthers;
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
} else if (head == "description") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
} else if (head == "isothers") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsOthers")) variable.Value = ssIsOthers; else variable.Optimized = true;
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
if (key.Equals(IdIsOthers)) {
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
if (key.Equals(IdDescription)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdIsOthers)) {
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
if (key == IdDescription) {
return ssDescription;
}
if (key == IdIsOthers) {
return ssIsOthers;
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
if (attributeKey == IdIsOthers.Key.AsGuid) {
return ssIsOthers;
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
ssDescription = (string) other.AttributeGet(IdDescription);
ChangedAttributes[1] = other.ChangedAttributeGet(IdDescription);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdDescription);
ssIsOthers = (bool) other.AttributeGet(IdIsOthers);
ChangedAttributes[2] = other.ChangedAttributeGet(IdIsOthers);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdIsOthers);
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
} // EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord

/// <summary>
/// RecordList type <code>Project_Asset_ServiceList</code> that represents a record list of
///  <code>Project_Asset_Service</code>
/// </summary>
public partial class RL_7838be117b7f5c2d9e5ade575405e0e9 : GenericRecordList<EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord>, IEnumerable, IEnumerator {

protected override EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord GetElementDefaultValue() {
return new EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord();
}

public T[] ToArray<T>(Func<EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7838be117b7f5c2d9e5ade575405e0e9 recordList, Func<EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7838be117b7f5c2d9e5ade575405e0e9(EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord[] array) {
  RL_7838be117b7f5c2d9e5ade575405e0e9 result = new RL_7838be117b7f5c2d9e5ade575405e0e9();
result.InnerFromArray(array);
    return result;
}

public static RL_7838be117b7f5c2d9e5ade575405e0e9 ToList<T>(T[] array, Func <T, EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord> converter) {
  RL_7838be117b7f5c2d9e5ade575405e0e9 result = new RL_7838be117b7f5c2d9e5ade575405e0e9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7838be117b7f5c2d9e5ade575405e0e9 FromRestList<T>(RestList<T> restList, Func <T, EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord> converter) {
  RL_7838be117b7f5c2d9e5ade575405e0e9 result = new RL_7838be117b7f5c2d9e5ade575405e0e9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7838be117b7f5c2d9e5ade575405e0e9() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord> NewList() {
return new RL_7838be117b7f5c2d9e5ade575405e0e9();
}


} // RL_7838be117b7f5c2d9e5ade575405e0e9
}
