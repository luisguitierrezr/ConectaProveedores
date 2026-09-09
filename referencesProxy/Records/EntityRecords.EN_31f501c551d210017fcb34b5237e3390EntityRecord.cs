using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] Region (gnn1KwsO9UO0zKf5nd60tQ)
///  <code>EN_31f501c551d210017fcb34b5237e3390EntityRecord</code> that represents <code>Region</code
/// > <p>Description: Entity holds all the regions.</p>
/// </summary>
// Name: Region
public partial struct EN_31f501c551d210017fcb34b5237e3390EntityRecord : ITypedRecord<EN_31f501c551d210017fcb34b5237e3390EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*YuewTHbWe0qR4Bh9yqZ8dw");
internal static readonly GlobalObjectKey IdCode = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*YfPPo6tH+02m00i8yYy8mQ");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*QkmpigT9REKDHzHBtxrZcw");
internal static readonly GlobalObjectKey IdDivisionFI = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*pWFsI2qW9UO46YSVAtMvLg");
internal static readonly GlobalObjectKey IdCentroRTP = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*nB+SWoBBFk+gnsFsK_t0aA");
internal static readonly GlobalObjectKey IdCommissionRegion = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*_L0Nr5gvWkOPSo30MsVvZg");
internal static readonly GlobalObjectKey IdIsActive = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*yB8_lVWpwk+sRKRkfzXXQw");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*HJlyiAfkvkqHCfqBv9Jacg");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*7LoYMYUHuUm6Rfarj9G7Gg");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*REDIufS290+iEfxNS7yFUA");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*Nr6bQWHMIEG8JDLtd7VbNg");
internal static readonly GlobalObjectKey IdIsFsP = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*RTl0xhlcwE+XpFZCk+mWSw");
internal static readonly GlobalObjectKey IdIsFcP = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*aC89mXVxykqq5zW1+mhxdw");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(13,true);
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

private string _ssName;
public string ssName{
  get{
      return _ssName;
  }
  set{
      if((_ssName!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssName = value;
      }
  }
}

private string _ssDivisionFI;
public string ssDivisionFI{
  get{
      return _ssDivisionFI;
  }
  set{
      if((_ssDivisionFI!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssDivisionFI = value;
      }
  }
}

private string _ssCentroRTP;
public string ssCentroRTP{
  get{
      return _ssCentroRTP;
  }
  set{
      if((_ssCentroRTP!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssCentroRTP = value;
      }
  }
}

private string _ssCommissionRegion;
public string ssCommissionRegion{
  get{
      return _ssCommissionRegion;
  }
  set{
      if((_ssCommissionRegion!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssCommissionRegion = value;
      }
  }
}

private bool _ssIsActive;
public bool ssIsActive{
  get{
      return _ssIsActive;
  }
  set{
      if((_ssIsActive!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
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

private bool _ssIsFsP;
public bool ssIsFsP{
  get{
      return _ssIsFsP;
  }
  set{
      if((_ssIsFsP!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
          _ssIsFsP = value;
      }
  }
}

private bool _ssIsFcP;
public bool ssIsFcP{
  get{
      return _ssIsFcP;
  }
  set{
      if((_ssIsFcP!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
          _ssIsFcP = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord() {
ChangedAttributes = new BitArray(13,true);
OptimizedAttributes = new BitArray(13,false);
_ssId = 0L;
_ssCode = "";
_ssName = "";
_ssDivisionFI = "";
_ssCentroRTP = "";
_ssCommissionRegion = "";
_ssIsActive = true;
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssCreatedBy = "";
_ssUpdatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssUpdatedBy = "";
_ssIsFsP = false;
_ssIsFcP = false;
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
ssId = r.ReadLongInteger(index++, "Region.Id", 0L);
ssCode = r.ReadText(index++, "Region.Code", "");
ssName = r.ReadText(index++, "Region.Name", "");
ssDivisionFI = r.ReadText(index++, "Region.DivisionFI", "");
ssCentroRTP = r.ReadText(index++, "Region.CentroRTP", "");
ssCommissionRegion = r.ReadText(index++, "Region.CommissionRegion", "");
ssIsActive = r.ReadBoolean(index++, "Region.IsActive", true);
ssCreatedOn = r.ReadDateTime(index++, "Region.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCreatedBy = r.ReadEntityReferenceText(index++, "Region.CreatedBy", "");
ssUpdatedOn = r.ReadDateTime(index++, "Region.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "Region.UpdatedBy", "");
ssIsFsP = r.ReadBoolean(index++, "Region.IsFsP", false);
ssIsFcP = r.ReadBoolean(index++, "Region.IsFcP", false);
ChangedAttributes = new BitArray(13,false);
OptimizedAttributes = new BitArray(13,false);
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
public void ReadIM(EN_31f501c551d210017fcb34b5237e3390EntityRecord r) {
this = r;
}


public static bool operator == (EN_31f501c551d210017fcb34b5237e3390EntityRecord a, EN_31f501c551d210017fcb34b5237e3390EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssCode != b.ssCode) return false;
if (a.ssName != b.ssName) return false;
if (a.ssDivisionFI != b.ssDivisionFI) return false;
if (a.ssCentroRTP != b.ssCentroRTP) return false;
if (a.ssCommissionRegion != b.ssCommissionRegion) return false;
if (a.ssIsActive != b.ssIsActive) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
if (a.ssIsFsP != b.ssIsFsP) return false;
if (a.ssIsFcP != b.ssIsFcP) return false;
return true;
}

public static bool operator != (EN_31f501c551d210017fcb34b5237e3390EntityRecord a, EN_31f501c551d210017fcb34b5237e3390EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_31f501c551d210017fcb34b5237e3390EntityRecord)) return false;
return (this == (EN_31f501c551d210017fcb34b5237e3390EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssCode.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssDivisionFI.GetHashCode()
 ^ ssCentroRTP.GetHashCode()
 ^ ssCommissionRegion.GetHashCode()
 ^ ssIsActive.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssUpdatedOn.GetHashCode()
 ^ ssUpdatedBy.GetHashCode()
 ^ ssIsFsP.GetHashCode()
 ^ ssIsFcP.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_31f501c551d210017fcb34b5237e3390EntityRecord Duplicate() {
EN_31f501c551d210017fcb34b5237e3390EntityRecord t;
t._ssId = this._ssId;
t._ssCode = this._ssCode;
t._ssName = this._ssName;
t._ssDivisionFI = this._ssDivisionFI;
t._ssCentroRTP = this._ssCentroRTP;
t._ssCommissionRegion = this._ssCommissionRegion;
t._ssIsActive = this._ssIsActive;
t._ssCreatedOn = this._ssCreatedOn;
t._ssCreatedBy = this._ssCreatedBy;
t._ssUpdatedOn = this._ssUpdatedOn;
t._ssUpdatedBy = this._ssUpdatedBy;
t._ssIsFsP = this._ssIsFsP;
t._ssIsFcP = this._ssIsFcP;
t.ChangedAttributes = new BitArray(13);
t.OptimizedAttributes = new BitArray(13);
for(int i = 0; i < 13; i++){
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
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "divisionfi") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DivisionFI")) variable.Value = ssDivisionFI; else variable.Optimized = true;
} else if (head == "centrortp") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CentroRTP")) variable.Value = ssCentroRTP; else variable.Optimized = true;
} else if (head == "commissionregion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CommissionRegion")) variable.Value = ssCommissionRegion; else variable.Optimized = true;
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
} else if (head == "isfsp") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsFsP")) variable.Value = ssIsFsP; else variable.Optimized = true;
} else if (head == "isfcp") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsFcP")) variable.Value = ssIsFcP; else variable.Optimized = true;
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
if (key.Equals(IdName)) {
return ChangedAttributes[2];
}
if (key.Equals(IdDivisionFI)) {
return ChangedAttributes[3];
}
if (key.Equals(IdCentroRTP)) {
return ChangedAttributes[4];
}
if (key.Equals(IdCommissionRegion)) {
return ChangedAttributes[5];
}
if (key.Equals(IdIsActive)) {
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
if (key.Equals(IdIsFsP)) {
return ChangedAttributes[11];
}
if (key.Equals(IdIsFcP)) {
return ChangedAttributes[12];
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
if (key.Equals(IdName)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdDivisionFI)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdCentroRTP)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdCommissionRegion)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdIsActive)) {
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
if (key.Equals(IdIsFsP)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdIsFcP)) {
return OptimizedAttributes[12];
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
if (key == IdName) {
return ssName;
}
if (key == IdDivisionFI) {
return ssDivisionFI;
}
if (key == IdCentroRTP) {
return ssCentroRTP;
}
if (key == IdCommissionRegion) {
return ssCommissionRegion;
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
if (key == IdIsFsP) {
return ssIsFsP;
}
if (key == IdIsFcP) {
return ssIsFcP;
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
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdDivisionFI.Key.AsGuid) {
return ssDivisionFI;
}
if (attributeKey == IdCentroRTP.Key.AsGuid) {
return ssCentroRTP;
}
if (attributeKey == IdCommissionRegion.Key.AsGuid) {
return ssCommissionRegion;
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
if (attributeKey == IdIsFsP.Key.AsGuid) {
return ssIsFsP;
}
if (attributeKey == IdIsFcP.Key.AsGuid) {
return ssIsFcP;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(13);
OptimizedAttributes = new BitArray(13);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssCode = (string) other.AttributeGet(IdCode);
ChangedAttributes[1] = other.ChangedAttributeGet(IdCode);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdCode);
ssName = (string) other.AttributeGet(IdName);
ChangedAttributes[2] = other.ChangedAttributeGet(IdName);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdName);
ssDivisionFI = (string) other.AttributeGet(IdDivisionFI);
ChangedAttributes[3] = other.ChangedAttributeGet(IdDivisionFI);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdDivisionFI);
ssCentroRTP = (string) other.AttributeGet(IdCentroRTP);
ChangedAttributes[4] = other.ChangedAttributeGet(IdCentroRTP);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdCentroRTP);
ssCommissionRegion = (string) other.AttributeGet(IdCommissionRegion);
ChangedAttributes[5] = other.ChangedAttributeGet(IdCommissionRegion);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdCommissionRegion);
ssIsActive = (bool) other.AttributeGet(IdIsActive);
ChangedAttributes[6] = other.ChangedAttributeGet(IdIsActive);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdIsActive);
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
ssIsFsP = (bool) other.AttributeGet(IdIsFsP);
ChangedAttributes[11] = other.ChangedAttributeGet(IdIsFsP);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdIsFsP);
ssIsFcP = (bool) other.AttributeGet(IdIsFcP);
ChangedAttributes[12] = other.ChangedAttributeGet(IdIsFcP);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdIsFcP);
}
} // EN_31f501c551d210017fcb34b5237e3390EntityRecord

/// <summary>
/// RecordList type <code>RegionList</code> that represents a record list of <code>Region</code>
/// </summary>
public partial class RL_d986b6d1bea23262dd4c2e7877133273 : GenericRecordList<EN_31f501c551d210017fcb34b5237e3390EntityRecord>, IEnumerable, IEnumerator {

protected override EN_31f501c551d210017fcb34b5237e3390EntityRecord GetElementDefaultValue() {
return new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public T[] ToArray<T>(Func<EN_31f501c551d210017fcb34b5237e3390EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d986b6d1bea23262dd4c2e7877133273 recordList, Func<EN_31f501c551d210017fcb34b5237e3390EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d986b6d1bea23262dd4c2e7877133273(EN_31f501c551d210017fcb34b5237e3390EntityRecord[] array) {
  RL_d986b6d1bea23262dd4c2e7877133273 result = new RL_d986b6d1bea23262dd4c2e7877133273();
result.InnerFromArray(array);
    return result;
}

public static RL_d986b6d1bea23262dd4c2e7877133273 ToList<T>(T[] array, Func <T, EN_31f501c551d210017fcb34b5237e3390EntityRecord> converter) {
  RL_d986b6d1bea23262dd4c2e7877133273 result = new RL_d986b6d1bea23262dd4c2e7877133273();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d986b6d1bea23262dd4c2e7877133273 FromRestList<T>(RestList<T> restList, Func <T, EN_31f501c551d210017fcb34b5237e3390EntityRecord> converter) {
  RL_d986b6d1bea23262dd4c2e7877133273 result = new RL_d986b6d1bea23262dd4c2e7877133273();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d986b6d1bea23262dd4c2e7877133273() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_31f501c551d210017fcb34b5237e3390EntityRecord> NewList() {
return new RL_d986b6d1bea23262dd4c2e7877133273();
}


} // RL_d986b6d1bea23262dd4c2e7877133273
}
