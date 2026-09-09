using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] ApplicationRole (k_uAlSdZHk25msTLV8OqlA)
///  <code>EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord</code> that represent
/// s <code>ApplicationRole</code> <p>Description: Entity that holds application roles  </p>
/// </summary>
// Name: ApplicationRole
public partial struct EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord : ITypedRecord<EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*2hqI75CGD0yrniPtmjsZRQ");
internal static readonly GlobalObjectKey IdCode = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*Jf7Et+pv+0C1n1GdhQLtYg");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*97auGm16lkaG5fV+6pnkHA");
internal static readonly GlobalObjectKey IdIsActive = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*kKKal1Ye_kadDgwlrF0wwA");
internal static readonly GlobalObjectKey IdIsAreaUsuaria = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*rxGWcm7OlUe5Ruwg9P0JQw");
internal static readonly GlobalObjectKey IdIsAreaCxP = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*Tcbo75r+QEOKTelqIVc_9A");
internal static readonly GlobalObjectKey IdCanBulkApproveFolios = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*owvBbcUCWkelRj39960t6Q");

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

private bool _ssIsAreaUsuaria;
public bool ssIsAreaUsuaria{
  get{
      return _ssIsAreaUsuaria;
  }
  set{
      if((_ssIsAreaUsuaria!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssIsAreaUsuaria = value;
      }
  }
}

private bool _ssIsAreaCxP;
public bool ssIsAreaCxP{
  get{
      return _ssIsAreaCxP;
  }
  set{
      if((_ssIsAreaCxP!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssIsAreaCxP = value;
      }
  }
}

private bool _ssCanBulkApproveFolios;
public bool ssCanBulkApproveFolios{
  get{
      return _ssCanBulkApproveFolios;
  }
  set{
      if((_ssCanBulkApproveFolios!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssCanBulkApproveFolios = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord() {
ChangedAttributes = new BitArray(7,true);
OptimizedAttributes = new BitArray(7,false);
_ssId = 0L;
_ssCode = "";
_ssName = "";
_ssIsActive = false;
_ssIsAreaUsuaria = false;
_ssIsAreaCxP = false;
_ssCanBulkApproveFolios = false;
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
ssId = r.ReadLongInteger(index++, "ApplicationRole.Id", 0L);
ssCode = r.ReadText(index++, "ApplicationRole.Code", "");
ssName = r.ReadText(index++, "ApplicationRole.Name", "");
ssIsActive = r.ReadBoolean(index++, "ApplicationRole.IsActive", false);
ssIsAreaUsuaria = r.ReadBoolean(index++, "ApplicationRole.IsAreaUsuaria", false);
ssIsAreaCxP = r.ReadBoolean(index++, "ApplicationRole.IsAreaCxP", false);
ssCanBulkApproveFolios = r.ReadBoolean(index++, "ApplicationRole.CanBulkApproveFolios", false);
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
public void ReadIM(EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord r) {
this = r;
}


public static bool operator == (EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord a, EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssCode != b.ssCode) return false;
if (a.ssName != b.ssName) return false;
if (a.ssIsActive != b.ssIsActive) return false;
if (a.ssIsAreaUsuaria != b.ssIsAreaUsuaria) return false;
if (a.ssIsAreaCxP != b.ssIsAreaCxP) return false;
if (a.ssCanBulkApproveFolios != b.ssCanBulkApproveFolios) return false;
return true;
}

public static bool operator != (EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord a, EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord)) return false;
return (this == (EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssCode.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssIsActive.GetHashCode()
 ^ ssIsAreaUsuaria.GetHashCode()
 ^ ssIsAreaCxP.GetHashCode()
 ^ ssCanBulkApproveFolios.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord Duplicate() {
EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord t;
t._ssId = this._ssId;
t._ssCode = this._ssCode;
t._ssName = this._ssName;
t._ssIsActive = this._ssIsActive;
t._ssIsAreaUsuaria = this._ssIsAreaUsuaria;
t._ssIsAreaCxP = this._ssIsAreaCxP;
t._ssCanBulkApproveFolios = this._ssCanBulkApproveFolios;
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
} else if (head == "code") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Code")) variable.Value = ssCode; else variable.Optimized = true;
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "isactive") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsActive")) variable.Value = ssIsActive; else variable.Optimized = true;
} else if (head == "isareausuaria") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsAreaUsuaria")) variable.Value = ssIsAreaUsuaria; else variable.Optimized = true;
} else if (head == "isareacxp") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsAreaCxP")) variable.Value = ssIsAreaCxP; else variable.Optimized = true;
} else if (head == "canbulkapprovefolios") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CanBulkApproveFolios")) variable.Value = ssCanBulkApproveFolios; else variable.Optimized = true;
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
if (key.Equals(IdIsActive)) {
return ChangedAttributes[3];
}
if (key.Equals(IdIsAreaUsuaria)) {
return ChangedAttributes[4];
}
if (key.Equals(IdIsAreaCxP)) {
return ChangedAttributes[5];
}
if (key.Equals(IdCanBulkApproveFolios)) {
return ChangedAttributes[6];
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
if (key.Equals(IdIsActive)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdIsAreaUsuaria)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdIsAreaCxP)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdCanBulkApproveFolios)) {
return OptimizedAttributes[6];
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
if (key == IdIsActive) {
return ssIsActive;
}
if (key == IdIsAreaUsuaria) {
return ssIsAreaUsuaria;
}
if (key == IdIsAreaCxP) {
return ssIsAreaCxP;
}
if (key == IdCanBulkApproveFolios) {
return ssCanBulkApproveFolios;
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
if (attributeKey == IdIsActive.Key.AsGuid) {
return ssIsActive;
}
if (attributeKey == IdIsAreaUsuaria.Key.AsGuid) {
return ssIsAreaUsuaria;
}
if (attributeKey == IdIsAreaCxP.Key.AsGuid) {
return ssIsAreaCxP;
}
if (attributeKey == IdCanBulkApproveFolios.Key.AsGuid) {
return ssCanBulkApproveFolios;
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
ssCode = (string) other.AttributeGet(IdCode);
ChangedAttributes[1] = other.ChangedAttributeGet(IdCode);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdCode);
ssName = (string) other.AttributeGet(IdName);
ChangedAttributes[2] = other.ChangedAttributeGet(IdName);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdName);
ssIsActive = (bool) other.AttributeGet(IdIsActive);
ChangedAttributes[3] = other.ChangedAttributeGet(IdIsActive);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdIsActive);
ssIsAreaUsuaria = (bool) other.AttributeGet(IdIsAreaUsuaria);
ChangedAttributes[4] = other.ChangedAttributeGet(IdIsAreaUsuaria);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdIsAreaUsuaria);
ssIsAreaCxP = (bool) other.AttributeGet(IdIsAreaCxP);
ChangedAttributes[5] = other.ChangedAttributeGet(IdIsAreaCxP);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdIsAreaCxP);
ssCanBulkApproveFolios = (bool) other.AttributeGet(IdCanBulkApproveFolios);
ChangedAttributes[6] = other.ChangedAttributeGet(IdCanBulkApproveFolios);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdCanBulkApproveFolios);
}
} // EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord

/// <summary>
/// RecordList type <code>ApplicationRoleList</code> that represents a record list of
///  <code>ApplicationRole</code>
/// </summary>
public partial class RL_d1137ee59913ffd79de2d85b1dc0f95d : GenericRecordList<EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord>, IEnumerable, IEnumerator {

protected override EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord GetElementDefaultValue() {
return new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord();
}

public T[] ToArray<T>(Func<EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d1137ee59913ffd79de2d85b1dc0f95d recordList, Func<EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d1137ee59913ffd79de2d85b1dc0f95d(EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord[] array) {
  RL_d1137ee59913ffd79de2d85b1dc0f95d result = new RL_d1137ee59913ffd79de2d85b1dc0f95d();
result.InnerFromArray(array);
    return result;
}

public static RL_d1137ee59913ffd79de2d85b1dc0f95d ToList<T>(T[] array, Func <T, EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord> converter) {
  RL_d1137ee59913ffd79de2d85b1dc0f95d result = new RL_d1137ee59913ffd79de2d85b1dc0f95d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d1137ee59913ffd79de2d85b1dc0f95d FromRestList<T>(RestList<T> restList, Func <T, EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord> converter) {
  RL_d1137ee59913ffd79de2d85b1dc0f95d result = new RL_d1137ee59913ffd79de2d85b1dc0f95d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d1137ee59913ffd79de2d85b1dc0f95d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord> NewList() {
return new RL_d1137ee59913ffd79de2d85b1dc0f95d();
}


} // RL_d1137ee59913ffd79de2d85b1dc0f95d
}
