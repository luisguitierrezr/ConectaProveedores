using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] Company (tyrgtf14QE+WgPtjXRX5aQ)
///  <code>EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord</code> that represents <code>Company</code
/// > <p>Description: Entity holds all the Companies (In spanish Sociedades).</p>
/// </summary>
// Name: Company
public partial struct EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord : ITypedRecord<EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*XYLnILnmDEGcrwUMOK4U8Q");
internal static readonly GlobalObjectKey IdExternalId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*6u_0nMA_mE2Xg8+yD0AGHg");
internal static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*MRCaxXb_5UKG3KKHXgvI+g");
internal static readonly GlobalObjectKey IdRFC = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*JnZKO4jtDkS5EeUVe7o9ag");
internal static readonly GlobalObjectKey IdPostalCode = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*8oMqybzirkiQnbWEWcxx8g");
internal static readonly GlobalObjectKey IdCyAImport = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*_OHHw9qw7kG5zkoTwLOang");
internal static readonly GlobalObjectKey IdFsPUse = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*x6nAObdjFE6cXKkYfVU_eQ");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*AP0sMlSJLkeVbBPzq8TWtw");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*s9eaT_2qNUOXensJ6UCI8g");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*M+Zv7FgSekOsBBjYolFLpw");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*rpWcVxU+BEm9Iy6+HiSN7w");

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

private string _ssExternalId;
public string ssExternalId{
  get{
      return _ssExternalId;
  }
  set{
      if((_ssExternalId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssExternalId = value;
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

private string _ssRFC;
public string ssRFC{
  get{
      return _ssRFC;
  }
  set{
      if((_ssRFC!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssRFC = value;
      }
  }
}

private string _ssPostalCode;
public string ssPostalCode{
  get{
      return _ssPostalCode;
  }
  set{
      if((_ssPostalCode!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssPostalCode = value;
      }
  }
}

private bool _ssCyAImport;
public bool ssCyAImport{
  get{
      return _ssCyAImport;
  }
  set{
      if((_ssCyAImport!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssCyAImport = value;
      }
  }
}

private bool _ssFsPUse;
public bool ssFsPUse{
  get{
      return _ssFsPUse;
  }
  set{
      if((_ssFsPUse!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssFsPUse = value;
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

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord() {
ChangedAttributes = new BitArray(11,true);
OptimizedAttributes = new BitArray(11,false);
_ssId = 0L;
_ssExternalId = "";
_ssDescription = "";
_ssRFC = "";
_ssPostalCode = "";
_ssCyAImport = false;
_ssFsPUse = true;
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
ssId = r.ReadLongInteger(index++, "Company.Id", 0L);
ssExternalId = r.ReadText(index++, "Company.ExternalId", "");
ssDescription = r.ReadText(index++, "Company.Description", "");
ssRFC = r.ReadText(index++, "Company.RFC", "");
ssPostalCode = r.ReadText(index++, "Company.PostalCode", "");
ssCyAImport = r.ReadBoolean(index++, "Company.CyAImport", false);
ssFsPUse = r.ReadBoolean(index++, "Company.FsPUse", true);
ssCreatedOn = r.ReadDateTime(index++, "Company.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCreatedBy = r.ReadEntityReferenceText(index++, "Company.CreatedBy", "");
ssUpdatedOn = r.ReadDateTime(index++, "Company.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "Company.UpdatedBy", "");
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
public void ReadIM(EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord r) {
this = r;
}


public static bool operator == (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord a, EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssExternalId != b.ssExternalId) return false;
if (a.ssDescription != b.ssDescription) return false;
if (a.ssRFC != b.ssRFC) return false;
if (a.ssPostalCode != b.ssPostalCode) return false;
if (a.ssCyAImport != b.ssCyAImport) return false;
if (a.ssFsPUse != b.ssFsPUse) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
return true;
}

public static bool operator != (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord a, EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord)) return false;
return (this == (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssExternalId.GetHashCode()
 ^ ssDescription.GetHashCode()
 ^ ssRFC.GetHashCode()
 ^ ssPostalCode.GetHashCode()
 ^ ssCyAImport.GetHashCode()
 ^ ssFsPUse.GetHashCode()
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


public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord Duplicate() {
EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord t;
t._ssId = this._ssId;
t._ssExternalId = this._ssExternalId;
t._ssDescription = this._ssDescription;
t._ssRFC = this._ssRFC;
t._ssPostalCode = this._ssPostalCode;
t._ssCyAImport = this._ssCyAImport;
t._ssFsPUse = this._ssFsPUse;
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
} else if (head == "externalid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExternalId")) variable.Value = ssExternalId; else variable.Optimized = true;
} else if (head == "description") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
} else if (head == "rfc") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RFC")) variable.Value = ssRFC; else variable.Optimized = true;
} else if (head == "postalcode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PostalCode")) variable.Value = ssPostalCode; else variable.Optimized = true;
} else if (head == "cyaimport") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CyAImport")) variable.Value = ssCyAImport; else variable.Optimized = true;
} else if (head == "fspuse") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FsPUse")) variable.Value = ssFsPUse; else variable.Optimized = true;
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
if (key.Equals(IdExternalId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdDescription)) {
return ChangedAttributes[2];
}
if (key.Equals(IdRFC)) {
return ChangedAttributes[3];
}
if (key.Equals(IdPostalCode)) {
return ChangedAttributes[4];
}
if (key.Equals(IdCyAImport)) {
return ChangedAttributes[5];
}
if (key.Equals(IdFsPUse)) {
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
if (key.Equals(IdExternalId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdDescription)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdRFC)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdPostalCode)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdCyAImport)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdFsPUse)) {
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
if (key == IdExternalId) {
return ssExternalId;
}
if (key == IdDescription) {
return ssDescription;
}
if (key == IdRFC) {
return ssRFC;
}
if (key == IdPostalCode) {
return ssPostalCode;
}
if (key == IdCyAImport) {
return ssCyAImport;
}
if (key == IdFsPUse) {
return ssFsPUse;
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
if (attributeKey == IdExternalId.Key.AsGuid) {
return ssExternalId;
}
if (attributeKey == IdDescription.Key.AsGuid) {
return ssDescription;
}
if (attributeKey == IdRFC.Key.AsGuid) {
return ssRFC;
}
if (attributeKey == IdPostalCode.Key.AsGuid) {
return ssPostalCode;
}
if (attributeKey == IdCyAImport.Key.AsGuid) {
return ssCyAImport;
}
if (attributeKey == IdFsPUse.Key.AsGuid) {
return ssFsPUse;
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
ssExternalId = (string) other.AttributeGet(IdExternalId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdExternalId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdExternalId);
ssDescription = (string) other.AttributeGet(IdDescription);
ChangedAttributes[2] = other.ChangedAttributeGet(IdDescription);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdDescription);
ssRFC = (string) other.AttributeGet(IdRFC);
ChangedAttributes[3] = other.ChangedAttributeGet(IdRFC);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdRFC);
ssPostalCode = (string) other.AttributeGet(IdPostalCode);
ChangedAttributes[4] = other.ChangedAttributeGet(IdPostalCode);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdPostalCode);
ssCyAImport = (bool) other.AttributeGet(IdCyAImport);
ChangedAttributes[5] = other.ChangedAttributeGet(IdCyAImport);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdCyAImport);
ssFsPUse = (bool) other.AttributeGet(IdFsPUse);
ChangedAttributes[6] = other.ChangedAttributeGet(IdFsPUse);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdFsPUse);
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
} // EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord

/// <summary>
/// RecordList type <code>CompanyList</code> that represents a record list of <code>Company</code>
/// </summary>
public partial class RL_c137814ac517b1e8679b0756ef62a588 : GenericRecordList<EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord>, IEnumerable, IEnumerator {

protected override EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord GetElementDefaultValue() {
return new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
}

public T[] ToArray<T>(Func<EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c137814ac517b1e8679b0756ef62a588 recordList, Func<EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c137814ac517b1e8679b0756ef62a588(EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord[] array) {
  RL_c137814ac517b1e8679b0756ef62a588 result = new RL_c137814ac517b1e8679b0756ef62a588();
result.InnerFromArray(array);
    return result;
}

public static RL_c137814ac517b1e8679b0756ef62a588 ToList<T>(T[] array, Func <T, EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord> converter) {
  RL_c137814ac517b1e8679b0756ef62a588 result = new RL_c137814ac517b1e8679b0756ef62a588();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c137814ac517b1e8679b0756ef62a588 FromRestList<T>(RestList<T> restList, Func <T, EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord> converter) {
  RL_c137814ac517b1e8679b0756ef62a588 result = new RL_c137814ac517b1e8679b0756ef62a588();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c137814ac517b1e8679b0756ef62a588() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord> NewList() {
return new RL_c137814ac517b1e8679b0756ef62a588();
}


} // RL_c137814ac517b1e8679b0756ef62a588
}
