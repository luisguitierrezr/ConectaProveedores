namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] Z01_READ_TEXTReq (z2emte+jRUCqK6KIGarpeA)
///  <code>ST_c4a97e6963b2cd0d749b56dde8d26a02Structure</code> that represent
/// s <code>Z01_READ_TEXTReq</code> <p>Description: Z01_READ_TEXTReq</p>
/// </summary>
// Name: Z01_READ_TEXTReq
public partial struct ST_c4a97e6963b2cd0d749b56dde8d26a02Structure : ITypedRecord<ST_c4a97e6963b2cd0d749b56dde8d26a02Structure> {
internal static readonly GlobalObjectKey IdID = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*51za9Oc+rkmoadI8o6r09Q");
internal static readonly GlobalObjectKey IdNAME = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*p9ao2w_CekCmurr9MJTpSw");
internal static readonly GlobalObjectKey IdOBJECT = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*YwiI1lHqkE2sa2Ytmg4cSw");

public string ssID;

public string ssNAME;

public string ssOBJECT;


public BitArray OptimizedAttributes;

public ST_c4a97e6963b2cd0d749b56dde8d26a02Structure() {
OptimizedAttributes = null;
ssID = "";
ssNAME = "";
ssOBJECT = "";
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
ssID = r.ReadText(index++, "Z01_READ_TEXTReq.ID", "");
ssNAME = r.ReadText(index++, "Z01_READ_TEXTReq.NAME", "");
ssOBJECT = r.ReadText(index++, "Z01_READ_TEXTReq.OBJECT", "");
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
public void ReadIM(ST_c4a97e6963b2cd0d749b56dde8d26a02Structure r) {
this = r;
}


public static bool operator == (ST_c4a97e6963b2cd0d749b56dde8d26a02Structure a, ST_c4a97e6963b2cd0d749b56dde8d26a02Structure b) {
if (a.ssID != b.ssID) return false;
if (a.ssNAME != b.ssNAME) return false;
if (a.ssOBJECT != b.ssOBJECT) return false;
return true;
}

public static bool operator != (ST_c4a97e6963b2cd0d749b56dde8d26a02Structure a, ST_c4a97e6963b2cd0d749b56dde8d26a02Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_c4a97e6963b2cd0d749b56dde8d26a02Structure)) return false;
return (this == (ST_c4a97e6963b2cd0d749b56dde8d26a02Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssID.GetHashCode()
 ^ ssNAME.GetHashCode()
 ^ ssOBJECT.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_c4a97e6963b2cd0d749b56dde8d26a02Structure Duplicate() {
ST_c4a97e6963b2cd0d749b56dde8d26a02Structure t;
t.ssID = this.ssID;
t.ssNAME = this.ssNAME;
t.ssOBJECT = this.ssOBJECT;
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
if (head == "id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ID")) variable.Value = ssID; else variable.Optimized = true;
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NAME")) variable.Value = ssNAME; else variable.Optimized = true;
} else if (head == "object") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OBJECT")) variable.Value = ssOBJECT; else variable.Optimized = true;
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
if (key == IdID) {
return ssID;
}
if (key == IdNAME) {
return ssNAME;
}
if (key == IdOBJECT) {
return ssOBJECT;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdID.Key.AsGuid) {
return ssID;
}
if (attributeKey == IdNAME.Key.AsGuid) {
return ssNAME;
}
if (attributeKey == IdOBJECT.Key.AsGuid) {
return ssOBJECT;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssID = (string) other.AttributeGet(IdID);
ssNAME = (string) other.AttributeGet(IdNAME);
ssOBJECT = (string) other.AttributeGet(IdOBJECT);
}
} // ST_c4a97e6963b2cd0d749b56dde8d26a02Structure
/// <summary>
/// RecordList type <code>Z01_READ_TEXTReqList</code> that represents a record list of
///  <code>Z01_READ_TEXTReq</code>
/// </summary>
public partial class RL_fdef59b8d7e6ae6ccc41aa372b695b69 : GenericRecordList<ST_c4a97e6963b2cd0d749b56dde8d26a02Structure>, IEnumerable, IEnumerator {

protected override ST_c4a97e6963b2cd0d749b56dde8d26a02Structure GetElementDefaultValue() {
return new ST_c4a97e6963b2cd0d749b56dde8d26a02Structure();
}

public T[] ToArray<T>(Func<ST_c4a97e6963b2cd0d749b56dde8d26a02Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_fdef59b8d7e6ae6ccc41aa372b695b69 recordList, Func<ST_c4a97e6963b2cd0d749b56dde8d26a02Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_fdef59b8d7e6ae6ccc41aa372b695b69(ST_c4a97e6963b2cd0d749b56dde8d26a02Structure[] array) {
  RL_fdef59b8d7e6ae6ccc41aa372b695b69 result = new RL_fdef59b8d7e6ae6ccc41aa372b695b69();
result.InnerFromArray(array);
    return result;
}

public static RL_fdef59b8d7e6ae6ccc41aa372b695b69 ToList<T>(T[] array, Func <T, ST_c4a97e6963b2cd0d749b56dde8d26a02Structure> converter) {
  RL_fdef59b8d7e6ae6ccc41aa372b695b69 result = new RL_fdef59b8d7e6ae6ccc41aa372b695b69();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_fdef59b8d7e6ae6ccc41aa372b695b69 FromRestList<T>(RestList<T> restList, Func <T, ST_c4a97e6963b2cd0d749b56dde8d26a02Structure> converter) {
  RL_fdef59b8d7e6ae6ccc41aa372b695b69 result = new RL_fdef59b8d7e6ae6ccc41aa372b695b69();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_fdef59b8d7e6ae6ccc41aa372b695b69() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_c4a97e6963b2cd0d749b56dde8d26a02Structure> NewList() {
return new RL_fdef59b8d7e6ae6ccc41aa372b695b69();
}


} // RL_fdef59b8d7e6ae6ccc41aa372b695b69
}

