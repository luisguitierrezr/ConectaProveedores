namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] RETURN2 (oLo8aG49cUK8OTjKBQvmog)
///  <code>ST_e5256660414a7d3dddc63b7cbdd21e9cStructure</code> that represents <code>RETURN2</code
/// > <p>Description: </p>
/// </summary>
// Name: RETURN2
public partial struct ST_e5256660414a7d3dddc63b7cbdd21e9cStructure : ITypedRecord<ST_e5256660414a7d3dddc63b7cbdd21e9cStructure> {
internal static readonly GlobalObjectKey IdTYPE = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*dJB1XwfKJUiAauMc7Y8c2A");
internal static readonly GlobalObjectKey IdCODE = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*nGoMFXNSN06EcjbKDMm4Xw");
internal static readonly GlobalObjectKey IdMESSAGE = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*a14C2O4b9ES5iRHz9VZkAg");
internal static readonly GlobalObjectKey IdLOG_NO = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*lC6ualIN2UuysQ41E79Eqw");
internal static readonly GlobalObjectKey IdLOG_MSG_NO = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*k36j0KfYNkW4XQmViU22Qg");
internal static readonly GlobalObjectKey IdMESSAGE_V1 = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*pqEG8Pg1C0KtxEogJ4c30w");
internal static readonly GlobalObjectKey IdMESSAGE_V2 = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*BDNZEED4IEiPFGPei17TRw");
internal static readonly GlobalObjectKey IdMESSAGE_V3 = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*hE43PE5NR0KC5QFiP0N4gw");
internal static readonly GlobalObjectKey IdMESSAGE_V4 = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*ui5VAM0h_0mdHPWNepIOGg");

public string ssTYPE;

public string ssCODE;

public string ssMESSAGE;

public string ssLOG_NO;

public int ssLOG_MSG_NO;

public string ssMESSAGE_V1;

public string ssMESSAGE_V2;

public string ssMESSAGE_V3;

public string ssMESSAGE_V4;


public BitArray OptimizedAttributes;

public ST_e5256660414a7d3dddc63b7cbdd21e9cStructure() {
OptimizedAttributes = null;
ssTYPE = "";
ssCODE = "";
ssMESSAGE = "";
ssLOG_NO = "";
ssLOG_MSG_NO = -2147483648;
ssMESSAGE_V1 = "";
ssMESSAGE_V2 = "";
ssMESSAGE_V3 = "";
ssMESSAGE_V4 = "";
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
ssTYPE = r.ReadText(index++, "RETURN2.TYPE", "");
ssCODE = r.ReadText(index++, "RETURN2.CODE", "");
ssMESSAGE = r.ReadText(index++, "RETURN2.MESSAGE", "");
ssLOG_NO = r.ReadText(index++, "RETURN2.LOG_NO", "");
ssLOG_MSG_NO = r.ReadInteger(index++, "RETURN2.LOG_MSG_NO", 0);
ssMESSAGE_V1 = r.ReadText(index++, "RETURN2.MESSAGE_V1", "");
ssMESSAGE_V2 = r.ReadText(index++, "RETURN2.MESSAGE_V2", "");
ssMESSAGE_V3 = r.ReadText(index++, "RETURN2.MESSAGE_V3", "");
ssMESSAGE_V4 = r.ReadText(index++, "RETURN2.MESSAGE_V4", "");
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
public void ReadIM(ST_e5256660414a7d3dddc63b7cbdd21e9cStructure r) {
this = r;
}


public static bool operator == (ST_e5256660414a7d3dddc63b7cbdd21e9cStructure a, ST_e5256660414a7d3dddc63b7cbdd21e9cStructure b) {
if (a.ssTYPE != b.ssTYPE) return false;
if (a.ssCODE != b.ssCODE) return false;
if (a.ssMESSAGE != b.ssMESSAGE) return false;
if (a.ssLOG_NO != b.ssLOG_NO) return false;
if (a.ssLOG_MSG_NO != b.ssLOG_MSG_NO) return false;
if (a.ssMESSAGE_V1 != b.ssMESSAGE_V1) return false;
if (a.ssMESSAGE_V2 != b.ssMESSAGE_V2) return false;
if (a.ssMESSAGE_V3 != b.ssMESSAGE_V3) return false;
if (a.ssMESSAGE_V4 != b.ssMESSAGE_V4) return false;
return true;
}

public static bool operator != (ST_e5256660414a7d3dddc63b7cbdd21e9cStructure a, ST_e5256660414a7d3dddc63b7cbdd21e9cStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_e5256660414a7d3dddc63b7cbdd21e9cStructure)) return false;
return (this == (ST_e5256660414a7d3dddc63b7cbdd21e9cStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssTYPE.GetHashCode()
 ^ ssCODE.GetHashCode()
 ^ ssMESSAGE.GetHashCode()
 ^ ssLOG_NO.GetHashCode()
 ^ ssLOG_MSG_NO.GetHashCode()
 ^ ssMESSAGE_V1.GetHashCode()
 ^ ssMESSAGE_V2.GetHashCode()
 ^ ssMESSAGE_V3.GetHashCode()
 ^ ssMESSAGE_V4.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_e5256660414a7d3dddc63b7cbdd21e9cStructure Duplicate() {
ST_e5256660414a7d3dddc63b7cbdd21e9cStructure t;
t.ssTYPE = this.ssTYPE;
t.ssCODE = this.ssCODE;
t.ssMESSAGE = this.ssMESSAGE;
t.ssLOG_NO = this.ssLOG_NO;
t.ssLOG_MSG_NO = this.ssLOG_MSG_NO;
t.ssMESSAGE_V1 = this.ssMESSAGE_V1;
t.ssMESSAGE_V2 = this.ssMESSAGE_V2;
t.ssMESSAGE_V3 = this.ssMESSAGE_V3;
t.ssMESSAGE_V4 = this.ssMESSAGE_V4;
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
if (head == "type") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TYPE")) variable.Value = ssTYPE; else variable.Optimized = true;
} else if (head == "code") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CODE")) variable.Value = ssCODE; else variable.Optimized = true;
} else if (head == "message") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MESSAGE")) variable.Value = ssMESSAGE; else variable.Optimized = true;
} else if (head == "log_no") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LOG_NO")) variable.Value = ssLOG_NO; else variable.Optimized = true;
} else if (head == "log_msg_no") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LOG_MSG_NO")) variable.Value = ssLOG_MSG_NO; else variable.Optimized = true;
} else if (head == "message_v1") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MESSAGE_V1")) variable.Value = ssMESSAGE_V1; else variable.Optimized = true;
} else if (head == "message_v2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MESSAGE_V2")) variable.Value = ssMESSAGE_V2; else variable.Optimized = true;
} else if (head == "message_v3") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MESSAGE_V3")) variable.Value = ssMESSAGE_V3; else variable.Optimized = true;
} else if (head == "message_v4") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MESSAGE_V4")) variable.Value = ssMESSAGE_V4; else variable.Optimized = true;
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
if (key == IdTYPE) {
return ssTYPE;
}
if (key == IdCODE) {
return ssCODE;
}
if (key == IdMESSAGE) {
return ssMESSAGE;
}
if (key == IdLOG_NO) {
return ssLOG_NO;
}
if (key == IdLOG_MSG_NO) {
return ssLOG_MSG_NO;
}
if (key == IdMESSAGE_V1) {
return ssMESSAGE_V1;
}
if (key == IdMESSAGE_V2) {
return ssMESSAGE_V2;
}
if (key == IdMESSAGE_V3) {
return ssMESSAGE_V3;
}
if (key == IdMESSAGE_V4) {
return ssMESSAGE_V4;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTYPE.Key.AsGuid) {
return ssTYPE;
}
if (attributeKey == IdCODE.Key.AsGuid) {
return ssCODE;
}
if (attributeKey == IdMESSAGE.Key.AsGuid) {
return ssMESSAGE;
}
if (attributeKey == IdLOG_NO.Key.AsGuid) {
return ssLOG_NO;
}
if (attributeKey == IdLOG_MSG_NO.Key.AsGuid) {
return ssLOG_MSG_NO;
}
if (attributeKey == IdMESSAGE_V1.Key.AsGuid) {
return ssMESSAGE_V1;
}
if (attributeKey == IdMESSAGE_V2.Key.AsGuid) {
return ssMESSAGE_V2;
}
if (attributeKey == IdMESSAGE_V3.Key.AsGuid) {
return ssMESSAGE_V3;
}
if (attributeKey == IdMESSAGE_V4.Key.AsGuid) {
return ssMESSAGE_V4;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssTYPE = (string) other.AttributeGet(IdTYPE);
ssCODE = (string) other.AttributeGet(IdCODE);
ssMESSAGE = (string) other.AttributeGet(IdMESSAGE);
ssLOG_NO = (string) other.AttributeGet(IdLOG_NO);
ssLOG_MSG_NO = (int) other.AttributeGet(IdLOG_MSG_NO);
ssMESSAGE_V1 = (string) other.AttributeGet(IdMESSAGE_V1);
ssMESSAGE_V2 = (string) other.AttributeGet(IdMESSAGE_V2);
ssMESSAGE_V3 = (string) other.AttributeGet(IdMESSAGE_V3);
ssMESSAGE_V4 = (string) other.AttributeGet(IdMESSAGE_V4);
}
} // ST_e5256660414a7d3dddc63b7cbdd21e9cStructure
/// <summary>
/// RecordList type <code>RETURN2List</code> that represents a record list of <code>RETURN2</code>
/// </summary>
public partial class RL_65d21e721e0e9ab271c5a6b937d07f56 : GenericRecordList<ST_e5256660414a7d3dddc63b7cbdd21e9cStructure>, IEnumerable, IEnumerator {

protected override ST_e5256660414a7d3dddc63b7cbdd21e9cStructure GetElementDefaultValue() {
return new ST_e5256660414a7d3dddc63b7cbdd21e9cStructure();
}

public T[] ToArray<T>(Func<ST_e5256660414a7d3dddc63b7cbdd21e9cStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_65d21e721e0e9ab271c5a6b937d07f56 recordList, Func<ST_e5256660414a7d3dddc63b7cbdd21e9cStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_65d21e721e0e9ab271c5a6b937d07f56(ST_e5256660414a7d3dddc63b7cbdd21e9cStructure[] array) {
  RL_65d21e721e0e9ab271c5a6b937d07f56 result = new RL_65d21e721e0e9ab271c5a6b937d07f56();
result.InnerFromArray(array);
    return result;
}

public static RL_65d21e721e0e9ab271c5a6b937d07f56 ToList<T>(T[] array, Func <T, ST_e5256660414a7d3dddc63b7cbdd21e9cStructure> converter) {
  RL_65d21e721e0e9ab271c5a6b937d07f56 result = new RL_65d21e721e0e9ab271c5a6b937d07f56();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_65d21e721e0e9ab271c5a6b937d07f56 FromRestList<T>(RestList<T> restList, Func <T, ST_e5256660414a7d3dddc63b7cbdd21e9cStructure> converter) {
  RL_65d21e721e0e9ab271c5a6b937d07f56 result = new RL_65d21e721e0e9ab271c5a6b937d07f56();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_65d21e721e0e9ab271c5a6b937d07f56() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_e5256660414a7d3dddc63b7cbdd21e9cStructure> NewList() {
return new RL_65d21e721e0e9ab271c5a6b937d07f56();
}


} // RL_65d21e721e0e9ab271c5a6b937d07f56
}

