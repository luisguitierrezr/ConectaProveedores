using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] Manuals (o4s0y_pfM0ChUxEsVE17sQ)
///  <code>EN_f9557b941e05ea8155a182da4f23a896EntityRecord</code> that represents <code>Manuals</code
/// > <p>Description: Manuals</p>
/// </summary>
// Name: Manuals
public partial struct EN_f9557b941e05ea8155a182da4f23a896EntityRecord : ITypedRecord<EN_f9557b941e05ea8155a182da4f23a896EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*IKrxweeA10qkOtGJvqvA9w");
internal static readonly GlobalObjectKey IdTitle = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*XHBfDFKIkkuSb3mHxSShCA");
internal static readonly GlobalObjectKey IdAppConceptId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*sorplfqfc0W+uAodE5ibBw");
internal static readonly GlobalObjectKey IdConceptId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*gznz9tiVzk++gwfVUfJxKA");
internal static readonly GlobalObjectKey IdShortDescription = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*fm4EiNpBGEC_lwXOIP5Vyw");
internal static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*4Wq1Ww51K06Jp8WD8w3hPQ");
internal static readonly GlobalObjectKey IdStar = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*nxxsNFc8zUyM6LxE8ASdJA");
internal static readonly GlobalObjectKey IdForProveedor = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*Ug7JG+yzLkeHrRw9WZ0M9A");
internal static readonly GlobalObjectKey IdIsVideo = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*nVyAh+V8cEq6cxUYgDHBZA");
internal static readonly GlobalObjectKey IdIsActive = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*FLZbOtrShkCx3bvr9dxRXA");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*zJE9vHjw+Em489rowugqfw");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*Vyu2VLygYU69ksy2TjGhFA");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(12,true);
          _ssId = value;
      }
  }
}

private string _ssTitle;
public string ssTitle{
  get{
      return _ssTitle;
  }
  set{
      if((_ssTitle!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssTitle = value;
      }
  }
}

private int _ssAppConceptId;
public int ssAppConceptId{
  get{
      return _ssAppConceptId;
  }
  set{
      if((_ssAppConceptId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssAppConceptId = value;
      }
  }
}

private int _ssConceptId;
public int ssConceptId{
  get{
      return _ssConceptId;
  }
  set{
      if((_ssConceptId!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssConceptId = value;
      }
  }
}

private string _ssShortDescription;
public string ssShortDescription{
  get{
      return _ssShortDescription;
  }
  set{
      if((_ssShortDescription!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssShortDescription = value;
      }
  }
}

private string _ssDescription;
public string ssDescription{
  get{
      return _ssDescription;
  }
  set{
      if((_ssDescription!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssDescription = value;
      }
  }
}

private bool _ssStar;
public bool ssStar{
  get{
      return _ssStar;
  }
  set{
      if((_ssStar!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssStar = value;
      }
  }
}

private bool _ssForProveedor;
public bool ssForProveedor{
  get{
      return _ssForProveedor;
  }
  set{
      if((_ssForProveedor!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssForProveedor = value;
      }
  }
}

private bool _ssIsVideo;
public bool ssIsVideo{
  get{
      return _ssIsVideo;
  }
  set{
      if((_ssIsVideo!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssIsVideo = value;
      }
  }
}

private bool _ssIsActive;
public bool ssIsActive{
  get{
      return _ssIsActive;
  }
  set{
      if((_ssIsActive!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
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
      if((_ssCreatedOn!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
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
      if((_ssCreatedBy!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
          _ssCreatedBy = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_f9557b941e05ea8155a182da4f23a896EntityRecord() {
ChangedAttributes = new BitArray(12,true);
OptimizedAttributes = new BitArray(12,false);
_ssId = 0L;
_ssTitle = "";
_ssAppConceptId = 0;
_ssConceptId = 0;
_ssShortDescription = "";
_ssDescription = "";
_ssStar = false;
_ssForProveedor = false;
_ssIsVideo = false;
_ssIsActive = true;
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssCreatedBy = "";
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
ssId = r.ReadLongInteger(index++, "Manuals.Id", 0L);
ssTitle = r.ReadText(index++, "Manuals.Title", "");
ssAppConceptId = r.ReadEntityReference(index++, "Manuals.AppConceptId", 0);
ssConceptId = r.ReadEntityReference(index++, "Manuals.ConceptId", 0);
ssShortDescription = r.ReadText(index++, "Manuals.ShortDescription", "");
ssDescription = r.ReadText(index++, "Manuals.Description", "");
ssStar = r.ReadBoolean(index++, "Manuals.Star", false);
ssForProveedor = r.ReadBoolean(index++, "Manuals.ForProveedor", false);
ssIsVideo = r.ReadBoolean(index++, "Manuals.IsVideo", false);
ssIsActive = r.ReadBoolean(index++, "Manuals.IsActive", true);
ssCreatedOn = r.ReadDateTime(index++, "Manuals.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCreatedBy = r.ReadEntityReferenceText(index++, "Manuals.CreatedBy", "");
ChangedAttributes = new BitArray(12,false);
OptimizedAttributes = new BitArray(12,false);
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
public void ReadIM(EN_f9557b941e05ea8155a182da4f23a896EntityRecord r) {
this = r;
}


public static bool operator == (EN_f9557b941e05ea8155a182da4f23a896EntityRecord a, EN_f9557b941e05ea8155a182da4f23a896EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssTitle != b.ssTitle) return false;
if (a.ssAppConceptId != b.ssAppConceptId) return false;
if (a.ssConceptId != b.ssConceptId) return false;
if (a.ssShortDescription != b.ssShortDescription) return false;
if (a.ssDescription != b.ssDescription) return false;
if (a.ssStar != b.ssStar) return false;
if (a.ssForProveedor != b.ssForProveedor) return false;
if (a.ssIsVideo != b.ssIsVideo) return false;
if (a.ssIsActive != b.ssIsActive) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
return true;
}

public static bool operator != (EN_f9557b941e05ea8155a182da4f23a896EntityRecord a, EN_f9557b941e05ea8155a182da4f23a896EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_f9557b941e05ea8155a182da4f23a896EntityRecord)) return false;
return (this == (EN_f9557b941e05ea8155a182da4f23a896EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssTitle.GetHashCode()
 ^ ssAppConceptId.GetHashCode()
 ^ ssConceptId.GetHashCode()
 ^ ssShortDescription.GetHashCode()
 ^ ssDescription.GetHashCode()
 ^ ssStar.GetHashCode()
 ^ ssForProveedor.GetHashCode()
 ^ ssIsVideo.GetHashCode()
 ^ ssIsActive.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_f9557b941e05ea8155a182da4f23a896EntityRecord Duplicate() {
EN_f9557b941e05ea8155a182da4f23a896EntityRecord t;
t._ssId = this._ssId;
t._ssTitle = this._ssTitle;
t._ssAppConceptId = this._ssAppConceptId;
t._ssConceptId = this._ssConceptId;
t._ssShortDescription = this._ssShortDescription;
t._ssDescription = this._ssDescription;
t._ssStar = this._ssStar;
t._ssForProveedor = this._ssForProveedor;
t._ssIsVideo = this._ssIsVideo;
t._ssIsActive = this._ssIsActive;
t._ssCreatedOn = this._ssCreatedOn;
t._ssCreatedBy = this._ssCreatedBy;
t.ChangedAttributes = new BitArray(12);
t.OptimizedAttributes = new BitArray(12);
for(int i = 0; i < 12; i++){
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
} else if (head == "title") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Title")) variable.Value = ssTitle; else variable.Optimized = true;
} else if (head == "appconceptid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AppConceptId")) variable.Value = ssAppConceptId; else variable.Optimized = true;
} else if (head == "conceptid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ConceptId")) variable.Value = ssConceptId; else variable.Optimized = true;
} else if (head == "shortdescription") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ShortDescription")) variable.Value = ssShortDescription; else variable.Optimized = true;
} else if (head == "description") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
} else if (head == "star") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Star")) variable.Value = ssStar; else variable.Optimized = true;
} else if (head == "forproveedor") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ForProveedor")) variable.Value = ssForProveedor; else variable.Optimized = true;
} else if (head == "isvideo") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsVideo")) variable.Value = ssIsVideo; else variable.Optimized = true;
} else if (head == "isactive") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsActive")) variable.Value = ssIsActive; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdTitle)) {
return ChangedAttributes[1];
}
if (key.Equals(IdAppConceptId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdConceptId)) {
return ChangedAttributes[3];
}
if (key.Equals(IdShortDescription)) {
return ChangedAttributes[4];
}
if (key.Equals(IdDescription)) {
return ChangedAttributes[5];
}
if (key.Equals(IdStar)) {
return ChangedAttributes[6];
}
if (key.Equals(IdForProveedor)) {
return ChangedAttributes[7];
}
if (key.Equals(IdIsVideo)) {
return ChangedAttributes[8];
}
if (key.Equals(IdIsActive)) {
return ChangedAttributes[9];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[10];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[11];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdTitle)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdAppConceptId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdConceptId)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdShortDescription)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdDescription)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdStar)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdForProveedor)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdIsVideo)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdIsActive)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[11];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdTitle) {
return ssTitle;
}
if (key == IdAppConceptId) {
return ssAppConceptId;
}
if (key == IdConceptId) {
return ssConceptId;
}
if (key == IdShortDescription) {
return ssShortDescription;
}
if (key == IdDescription) {
return ssDescription;
}
if (key == IdStar) {
return ssStar;
}
if (key == IdForProveedor) {
return ssForProveedor;
}
if (key == IdIsVideo) {
return ssIsVideo;
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
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdTitle.Key.AsGuid) {
return ssTitle;
}
if (attributeKey == IdAppConceptId.Key.AsGuid) {
return ssAppConceptId;
}
if (attributeKey == IdConceptId.Key.AsGuid) {
return ssConceptId;
}
if (attributeKey == IdShortDescription.Key.AsGuid) {
return ssShortDescription;
}
if (attributeKey == IdDescription.Key.AsGuid) {
return ssDescription;
}
if (attributeKey == IdStar.Key.AsGuid) {
return ssStar;
}
if (attributeKey == IdForProveedor.Key.AsGuid) {
return ssForProveedor;
}
if (attributeKey == IdIsVideo.Key.AsGuid) {
return ssIsVideo;
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
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(12);
OptimizedAttributes = new BitArray(12);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssTitle = (string) other.AttributeGet(IdTitle);
ChangedAttributes[1] = other.ChangedAttributeGet(IdTitle);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdTitle);
ssAppConceptId = (int) other.AttributeGet(IdAppConceptId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdAppConceptId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdAppConceptId);
ssConceptId = (int) other.AttributeGet(IdConceptId);
ChangedAttributes[3] = other.ChangedAttributeGet(IdConceptId);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdConceptId);
ssShortDescription = (string) other.AttributeGet(IdShortDescription);
ChangedAttributes[4] = other.ChangedAttributeGet(IdShortDescription);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdShortDescription);
ssDescription = (string) other.AttributeGet(IdDescription);
ChangedAttributes[5] = other.ChangedAttributeGet(IdDescription);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdDescription);
ssStar = (bool) other.AttributeGet(IdStar);
ChangedAttributes[6] = other.ChangedAttributeGet(IdStar);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdStar);
ssForProveedor = (bool) other.AttributeGet(IdForProveedor);
ChangedAttributes[7] = other.ChangedAttributeGet(IdForProveedor);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdForProveedor);
ssIsVideo = (bool) other.AttributeGet(IdIsVideo);
ChangedAttributes[8] = other.ChangedAttributeGet(IdIsVideo);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdIsVideo);
ssIsActive = (bool) other.AttributeGet(IdIsActive);
ChangedAttributes[9] = other.ChangedAttributeGet(IdIsActive);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdIsActive);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[10] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdCreatedOn);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[11] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdCreatedBy);
}
} // EN_f9557b941e05ea8155a182da4f23a896EntityRecord

/// <summary>
/// RecordList type <code>ManualsList</code> that represents a record list of <code>Manuals</code>
/// </summary>
public partial class RL_ee0fa429e64a28b4fe2fba7f52ca962e : GenericRecordList<EN_f9557b941e05ea8155a182da4f23a896EntityRecord>, IEnumerable, IEnumerator {

protected override EN_f9557b941e05ea8155a182da4f23a896EntityRecord GetElementDefaultValue() {
return new EN_f9557b941e05ea8155a182da4f23a896EntityRecord();
}

public T[] ToArray<T>(Func<EN_f9557b941e05ea8155a182da4f23a896EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ee0fa429e64a28b4fe2fba7f52ca962e recordList, Func<EN_f9557b941e05ea8155a182da4f23a896EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ee0fa429e64a28b4fe2fba7f52ca962e(EN_f9557b941e05ea8155a182da4f23a896EntityRecord[] array) {
  RL_ee0fa429e64a28b4fe2fba7f52ca962e result = new RL_ee0fa429e64a28b4fe2fba7f52ca962e();
result.InnerFromArray(array);
    return result;
}

public static RL_ee0fa429e64a28b4fe2fba7f52ca962e ToList<T>(T[] array, Func <T, EN_f9557b941e05ea8155a182da4f23a896EntityRecord> converter) {
  RL_ee0fa429e64a28b4fe2fba7f52ca962e result = new RL_ee0fa429e64a28b4fe2fba7f52ca962e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ee0fa429e64a28b4fe2fba7f52ca962e FromRestList<T>(RestList<T> restList, Func <T, EN_f9557b941e05ea8155a182da4f23a896EntityRecord> converter) {
  RL_ee0fa429e64a28b4fe2fba7f52ca962e result = new RL_ee0fa429e64a28b4fe2fba7f52ca962e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ee0fa429e64a28b4fe2fba7f52ca962e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_f9557b941e05ea8155a182da4f23a896EntityRecord> NewList() {
return new RL_ee0fa429e64a28b4fe2fba7f52ca962e();
}


} // RL_ee0fa429e64a28b4fe2fba7f52ca962e
}
