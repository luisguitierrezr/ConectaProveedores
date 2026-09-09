namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] BAPI_GL_ACC_GETDETAILReq (62LNfCiykUOmbNzmtvLg_w)
///  <code>ST_442654d6c8649545cfc0a9d6bfc9f12cStructure</code> that represent
/// s <code>BAPI_GL_ACC_GETDETAILReq</code> <p>Description: BAPI_GL_ACC_GETDETAILReq</p>
/// </summary>
// Name: BAPI_GL_ACC_GETDETAILReq
public partial struct ST_442654d6c8649545cfc0a9d6bfc9f12cStructure : ITypedRecord<ST_442654d6c8649545cfc0a9d6bfc9f12cStructure> {
internal static readonly GlobalObjectKey IdCOMPANYCODE = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*xKeIaby1EEGzglkGYyrWwg");
internal static readonly GlobalObjectKey IdGLACCT = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*OxXNPRyxGkOkr9KNlG7V6A");
internal static readonly GlobalObjectKey IdLANGUAGE = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*9nsZvmZHEU2lgOscbNJClA");
internal static readonly GlobalObjectKey IdLANGUAGE_ISO = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*60+5PJs4YU+6616if6wOXQ");
internal static readonly GlobalObjectKey IdTEXT_ONLY = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*k7+KOa+6VkOJEi9WdynCbw");

public string ssCOMPANYCODE;

public string ssGLACCT;

public string ssLANGUAGE;

public string ssLANGUAGE_ISO;

public string ssTEXT_ONLY;


public BitArray OptimizedAttributes;

public ST_442654d6c8649545cfc0a9d6bfc9f12cStructure() {
OptimizedAttributes = null;
ssCOMPANYCODE = "";
ssGLACCT = "";
ssLANGUAGE = "";
ssLANGUAGE_ISO = "";
ssTEXT_ONLY = "";
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
ssCOMPANYCODE = r.ReadText(index++, "BAPI_GL_ACC_GETDETAILReq.COMPANYCODE", "");
ssGLACCT = r.ReadText(index++, "BAPI_GL_ACC_GETDETAILReq.GLACCT", "");
ssLANGUAGE = r.ReadText(index++, "BAPI_GL_ACC_GETDETAILReq.LANGUAGE", "");
ssLANGUAGE_ISO = r.ReadText(index++, "BAPI_GL_ACC_GETDETAILReq.LANGUAGE_ISO", "");
ssTEXT_ONLY = r.ReadText(index++, "BAPI_GL_ACC_GETDETAILReq.TEXT_ONLY", "");
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
public void ReadIM(ST_442654d6c8649545cfc0a9d6bfc9f12cStructure r) {
this = r;
}


public static bool operator == (ST_442654d6c8649545cfc0a9d6bfc9f12cStructure a, ST_442654d6c8649545cfc0a9d6bfc9f12cStructure b) {
if (a.ssCOMPANYCODE != b.ssCOMPANYCODE) return false;
if (a.ssGLACCT != b.ssGLACCT) return false;
if (a.ssLANGUAGE != b.ssLANGUAGE) return false;
if (a.ssLANGUAGE_ISO != b.ssLANGUAGE_ISO) return false;
if (a.ssTEXT_ONLY != b.ssTEXT_ONLY) return false;
return true;
}

public static bool operator != (ST_442654d6c8649545cfc0a9d6bfc9f12cStructure a, ST_442654d6c8649545cfc0a9d6bfc9f12cStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_442654d6c8649545cfc0a9d6bfc9f12cStructure)) return false;
return (this == (ST_442654d6c8649545cfc0a9d6bfc9f12cStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssCOMPANYCODE.GetHashCode()
 ^ ssGLACCT.GetHashCode()
 ^ ssLANGUAGE.GetHashCode()
 ^ ssLANGUAGE_ISO.GetHashCode()
 ^ ssTEXT_ONLY.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_442654d6c8649545cfc0a9d6bfc9f12cStructure Duplicate() {
ST_442654d6c8649545cfc0a9d6bfc9f12cStructure t;
t.ssCOMPANYCODE = this.ssCOMPANYCODE;
t.ssGLACCT = this.ssGLACCT;
t.ssLANGUAGE = this.ssLANGUAGE;
t.ssLANGUAGE_ISO = this.ssLANGUAGE_ISO;
t.ssTEXT_ONLY = this.ssTEXT_ONLY;
t.OptimizedAttributes = null;
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
if (head == "companycode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".COMPANYCODE")) variable.Value = ssCOMPANYCODE; else variable.Optimized = true;
} else if (head == "glacct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".GLACCT")) variable.Value = ssGLACCT; else variable.Optimized = true;
} else if (head == "language") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LANGUAGE")) variable.Value = ssLANGUAGE; else variable.Optimized = true;
} else if (head == "language_iso") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LANGUAGE_ISO")) variable.Value = ssLANGUAGE_ISO; else variable.Optimized = true;
} else if (head == "text_only") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TEXT_ONLY")) variable.Value = ssTEXT_ONLY; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdCOMPANYCODE) {
return ssCOMPANYCODE;
}
if (key == IdGLACCT) {
return ssGLACCT;
}
if (key == IdLANGUAGE) {
return ssLANGUAGE;
}
if (key == IdLANGUAGE_ISO) {
return ssLANGUAGE_ISO;
}
if (key == IdTEXT_ONLY) {
return ssTEXT_ONLY;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCOMPANYCODE.Key.AsGuid) {
return ssCOMPANYCODE;
}
if (attributeKey == IdGLACCT.Key.AsGuid) {
return ssGLACCT;
}
if (attributeKey == IdLANGUAGE.Key.AsGuid) {
return ssLANGUAGE;
}
if (attributeKey == IdLANGUAGE_ISO.Key.AsGuid) {
return ssLANGUAGE_ISO;
}
if (attributeKey == IdTEXT_ONLY.Key.AsGuid) {
return ssTEXT_ONLY;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssCOMPANYCODE = (string) other.AttributeGet(IdCOMPANYCODE);
ssGLACCT = (string) other.AttributeGet(IdGLACCT);
ssLANGUAGE = (string) other.AttributeGet(IdLANGUAGE);
ssLANGUAGE_ISO = (string) other.AttributeGet(IdLANGUAGE_ISO);
ssTEXT_ONLY = (string) other.AttributeGet(IdTEXT_ONLY);
}
} // ST_442654d6c8649545cfc0a9d6bfc9f12cStructure
/// <summary>
/// RecordList type <code>BAPI_GL_ACC_GETDETAILReqList</code> that represents a record list of
///  <code>BAPI_GL_ACC_GETDETAILReq</code>
/// </summary>
public partial class RL_6bf7ac3a2487b060c5d4cf26c0b64da8 : GenericRecordList<ST_442654d6c8649545cfc0a9d6bfc9f12cStructure>, IEnumerable, IEnumerator {

protected override ST_442654d6c8649545cfc0a9d6bfc9f12cStructure GetElementDefaultValue() {
return new ST_442654d6c8649545cfc0a9d6bfc9f12cStructure();
}

public T[] ToArray<T>(Func<ST_442654d6c8649545cfc0a9d6bfc9f12cStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6bf7ac3a2487b060c5d4cf26c0b64da8 recordList, Func<ST_442654d6c8649545cfc0a9d6bfc9f12cStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6bf7ac3a2487b060c5d4cf26c0b64da8(ST_442654d6c8649545cfc0a9d6bfc9f12cStructure[] array) {
  RL_6bf7ac3a2487b060c5d4cf26c0b64da8 result = new RL_6bf7ac3a2487b060c5d4cf26c0b64da8();
result.InnerFromArray(array);
    return result;
}

public static RL_6bf7ac3a2487b060c5d4cf26c0b64da8 ToList<T>(T[] array, Func <T, ST_442654d6c8649545cfc0a9d6bfc9f12cStructure> converter) {
  RL_6bf7ac3a2487b060c5d4cf26c0b64da8 result = new RL_6bf7ac3a2487b060c5d4cf26c0b64da8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6bf7ac3a2487b060c5d4cf26c0b64da8 FromRestList<T>(RestList<T> restList, Func <T, ST_442654d6c8649545cfc0a9d6bfc9f12cStructure> converter) {
  RL_6bf7ac3a2487b060c5d4cf26c0b64da8 result = new RL_6bf7ac3a2487b060c5d4cf26c0b64da8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6bf7ac3a2487b060c5d4cf26c0b64da8() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_442654d6c8649545cfc0a9d6bfc9f12cStructure> NewList() {
return new RL_6bf7ac3a2487b060c5d4cf26c0b64da8();
}


} // RL_6bf7ac3a2487b060c5d4cf26c0b64da8
}

