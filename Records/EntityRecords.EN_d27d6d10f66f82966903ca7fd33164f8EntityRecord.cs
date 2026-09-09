using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] EntraRole (UJJR0uSdVEamIs98+O4UPg)
///  <code>EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord</code> that represents <code>EntraRole</code
/// > <p>Description: Entra Roles</p>
/// </summary>
// Name: EntraRole
public partial struct EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord : ITypedRecord<EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*j4kCnXHpP0CbqoMWCCQXBg");
internal static readonly GlobalObjectKey IdRoleName = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*BNlG3GG1YESJ8dD3m6nqdA");
internal static readonly GlobalObjectKey IdIsAreaUsuaria = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*2OKSqmaZf0Ogqcv5NAVKcA");
internal static readonly GlobalObjectKey IdIsAreaCxP = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*y1+4r0Cn9EWM88jBsEaDXA");
internal static readonly GlobalObjectKey IdIsSolicitante = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*VoiiDPWtkEOvOB_HgYRywQ");
internal static readonly GlobalObjectKey IdIsAssistant = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*Ij2YBOgLy0+MStdNT2GhAg");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(6,true);
          _ssId = value;
      }
  }
}

private string _ssRoleName;
public string ssRoleName{
  get{
      return _ssRoleName;
  }
  set{
      if((_ssRoleName!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssRoleName = value;
      }
  }
}

private bool _ssIsAreaUsuaria;
public bool ssIsAreaUsuaria{
  get{
      return _ssIsAreaUsuaria;
  }
  set{
      if((_ssIsAreaUsuaria!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
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
      if((_ssIsAreaCxP!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssIsAreaCxP = value;
      }
  }
}

private bool _ssIsSolicitante;
public bool ssIsSolicitante{
  get{
      return _ssIsSolicitante;
  }
  set{
      if((_ssIsSolicitante!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssIsSolicitante = value;
      }
  }
}

private bool _ssIsAssistant;
public bool ssIsAssistant{
  get{
      return _ssIsAssistant;
  }
  set{
      if((_ssIsAssistant!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssIsAssistant = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord() {
ChangedAttributes = new BitArray(6,true);
OptimizedAttributes = new BitArray(6,false);
_ssId = 0L;
_ssRoleName = "";
_ssIsAreaUsuaria = false;
_ssIsAreaCxP = false;
_ssIsSolicitante = false;
_ssIsAssistant = false;
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
ssId = r.ReadLongInteger(index++, "EntraRole.Id", 0L);
ssRoleName = r.ReadText(index++, "EntraRole.RoleName", "");
ssIsAreaUsuaria = r.ReadBoolean(index++, "EntraRole.IsAreaUsuaria", false);
ssIsAreaCxP = r.ReadBoolean(index++, "EntraRole.IsAreaCxP", false);
ssIsSolicitante = r.ReadBoolean(index++, "EntraRole.IsSolicitante", false);
ssIsAssistant = r.ReadBoolean(index++, "EntraRole.IsAssistant", false);
ChangedAttributes = new BitArray(6,false);
OptimizedAttributes = new BitArray(6,false);
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
public void ReadIM(EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord r) {
this = r;
}


public static bool operator == (EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord a, EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssRoleName != b.ssRoleName) return false;
if (a.ssIsAreaUsuaria != b.ssIsAreaUsuaria) return false;
if (a.ssIsAreaCxP != b.ssIsAreaCxP) return false;
if (a.ssIsSolicitante != b.ssIsSolicitante) return false;
if (a.ssIsAssistant != b.ssIsAssistant) return false;
return true;
}

public static bool operator != (EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord a, EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord)) return false;
return (this == (EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssRoleName.GetHashCode()
 ^ ssIsAreaUsuaria.GetHashCode()
 ^ ssIsAreaCxP.GetHashCode()
 ^ ssIsSolicitante.GetHashCode()
 ^ ssIsAssistant.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord Duplicate() {
EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord t;
t._ssId = this._ssId;
t._ssRoleName = this._ssRoleName;
t._ssIsAreaUsuaria = this._ssIsAreaUsuaria;
t._ssIsAreaCxP = this._ssIsAreaCxP;
t._ssIsSolicitante = this._ssIsSolicitante;
t._ssIsAssistant = this._ssIsAssistant;
t.ChangedAttributes = new BitArray(6);
t.OptimizedAttributes = new BitArray(6);
for(int i = 0; i < 6; i++){
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
} else if (head == "rolename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RoleName")) variable.Value = ssRoleName; else variable.Optimized = true;
} else if (head == "isareausuaria") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsAreaUsuaria")) variable.Value = ssIsAreaUsuaria; else variable.Optimized = true;
} else if (head == "isareacxp") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsAreaCxP")) variable.Value = ssIsAreaCxP; else variable.Optimized = true;
} else if (head == "issolicitante") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsSolicitante")) variable.Value = ssIsSolicitante; else variable.Optimized = true;
} else if (head == "isassistant") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsAssistant")) variable.Value = ssIsAssistant; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdRoleName)) {
return ChangedAttributes[1];
}
if (key.Equals(IdIsAreaUsuaria)) {
return ChangedAttributes[2];
}
if (key.Equals(IdIsAreaCxP)) {
return ChangedAttributes[3];
}
if (key.Equals(IdIsSolicitante)) {
return ChangedAttributes[4];
}
if (key.Equals(IdIsAssistant)) {
return ChangedAttributes[5];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdRoleName)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdIsAreaUsuaria)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdIsAreaCxP)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdIsSolicitante)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdIsAssistant)) {
return OptimizedAttributes[5];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdRoleName) {
return ssRoleName;
}
if (key == IdIsAreaUsuaria) {
return ssIsAreaUsuaria;
}
if (key == IdIsAreaCxP) {
return ssIsAreaCxP;
}
if (key == IdIsSolicitante) {
return ssIsSolicitante;
}
if (key == IdIsAssistant) {
return ssIsAssistant;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdRoleName.Key.AsGuid) {
return ssRoleName;
}
if (attributeKey == IdIsAreaUsuaria.Key.AsGuid) {
return ssIsAreaUsuaria;
}
if (attributeKey == IdIsAreaCxP.Key.AsGuid) {
return ssIsAreaCxP;
}
if (attributeKey == IdIsSolicitante.Key.AsGuid) {
return ssIsSolicitante;
}
if (attributeKey == IdIsAssistant.Key.AsGuid) {
return ssIsAssistant;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(6);
OptimizedAttributes = new BitArray(6);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssRoleName = (string) other.AttributeGet(IdRoleName);
ChangedAttributes[1] = other.ChangedAttributeGet(IdRoleName);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdRoleName);
ssIsAreaUsuaria = (bool) other.AttributeGet(IdIsAreaUsuaria);
ChangedAttributes[2] = other.ChangedAttributeGet(IdIsAreaUsuaria);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdIsAreaUsuaria);
ssIsAreaCxP = (bool) other.AttributeGet(IdIsAreaCxP);
ChangedAttributes[3] = other.ChangedAttributeGet(IdIsAreaCxP);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdIsAreaCxP);
ssIsSolicitante = (bool) other.AttributeGet(IdIsSolicitante);
ChangedAttributes[4] = other.ChangedAttributeGet(IdIsSolicitante);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdIsSolicitante);
ssIsAssistant = (bool) other.AttributeGet(IdIsAssistant);
ChangedAttributes[5] = other.ChangedAttributeGet(IdIsAssistant);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdIsAssistant);
}
} // EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord

/// <summary>
/// RecordList type <code>EntraRoleList</code> that represents a record list of <code>EntraRole</code>
/// </summary>
public partial class RL_4a0a28ae3a2031f68134c0b52d864ebd : GenericRecordList<EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord>, IEnumerable, IEnumerator {

protected override EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord GetElementDefaultValue() {
return new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord();
}

public T[] ToArray<T>(Func<EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4a0a28ae3a2031f68134c0b52d864ebd recordList, Func<EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4a0a28ae3a2031f68134c0b52d864ebd(EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord[] array) {
  RL_4a0a28ae3a2031f68134c0b52d864ebd result = new RL_4a0a28ae3a2031f68134c0b52d864ebd();
result.InnerFromArray(array);
    return result;
}

public static RL_4a0a28ae3a2031f68134c0b52d864ebd ToList<T>(T[] array, Func <T, EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord> converter) {
  RL_4a0a28ae3a2031f68134c0b52d864ebd result = new RL_4a0a28ae3a2031f68134c0b52d864ebd();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4a0a28ae3a2031f68134c0b52d864ebd FromRestList<T>(RestList<T> restList, Func <T, EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord> converter) {
  RL_4a0a28ae3a2031f68134c0b52d864ebd result = new RL_4a0a28ae3a2031f68134c0b52d864ebd();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4a0a28ae3a2031f68134c0b52d864ebd() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord> NewList() {
return new RL_4a0a28ae3a2031f68134c0b52d864ebd();
}


} // RL_4a0a28ae3a2031f68134c0b52d864ebd
}
