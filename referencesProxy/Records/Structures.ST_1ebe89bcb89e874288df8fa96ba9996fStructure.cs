namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] LINES (OX7e0lPRLU2Cmvq2tK_FmQ)
///  <code>ST_1ebe89bcb89e874288df8fa96ba9996fStructure</code> that represents <code>LINES</code
/// > <p>Description: </p>
/// </summary>
// Name: LINES
public partial struct ST_1ebe89bcb89e874288df8fa96ba9996fStructure : ITypedRecord<ST_1ebe89bcb89e874288df8fa96ba9996fStructure> {
internal static readonly GlobalObjectKey IdTDFORMAT = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*SR7Tu_Xvy0ye+uM+FfshWQ");
internal static readonly GlobalObjectKey IdTDLINE = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*FGp8q6GFC0SPFQoC2PdGZw");

public string ssTDFORMAT;

public string ssTDLINE;


public BitArray OptimizedAttributes;

public ST_1ebe89bcb89e874288df8fa96ba9996fStructure() {
OptimizedAttributes = null;
ssTDFORMAT = "";
ssTDLINE = "";
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
ssTDFORMAT = r.ReadText(index++, "LINES.TDFORMAT", "");
ssTDLINE = r.ReadText(index++, "LINES.TDLINE", "");
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
public void ReadIM(ST_1ebe89bcb89e874288df8fa96ba9996fStructure r) {
this = r;
}


public static bool operator == (ST_1ebe89bcb89e874288df8fa96ba9996fStructure a, ST_1ebe89bcb89e874288df8fa96ba9996fStructure b) {
if (a.ssTDFORMAT != b.ssTDFORMAT) return false;
if (a.ssTDLINE != b.ssTDLINE) return false;
return true;
}

public static bool operator != (ST_1ebe89bcb89e874288df8fa96ba9996fStructure a, ST_1ebe89bcb89e874288df8fa96ba9996fStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_1ebe89bcb89e874288df8fa96ba9996fStructure)) return false;
return (this == (ST_1ebe89bcb89e874288df8fa96ba9996fStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssTDFORMAT.GetHashCode()
 ^ ssTDLINE.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_1ebe89bcb89e874288df8fa96ba9996fStructure Duplicate() {
ST_1ebe89bcb89e874288df8fa96ba9996fStructure t;
t.ssTDFORMAT = this.ssTDFORMAT;
t.ssTDLINE = this.ssTDLINE;
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
if (head == "tdformat") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TDFORMAT")) variable.Value = ssTDFORMAT; else variable.Optimized = true;
} else if (head == "tdline") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TDLINE")) variable.Value = ssTDLINE; else variable.Optimized = true;
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
if (key == IdTDFORMAT) {
return ssTDFORMAT;
}
if (key == IdTDLINE) {
return ssTDLINE;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTDFORMAT.Key.AsGuid) {
return ssTDFORMAT;
}
if (attributeKey == IdTDLINE.Key.AsGuid) {
return ssTDLINE;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssTDFORMAT = (string) other.AttributeGet(IdTDFORMAT);
ssTDLINE = (string) other.AttributeGet(IdTDLINE);
}
} // ST_1ebe89bcb89e874288df8fa96ba9996fStructure
/// <summary>
/// RecordList type <code>LINESList</code> that represents a record list of <code>LINES</code>
/// </summary>
public partial class RL_9f464d3e6033d129f48cd86ef45da46f : GenericRecordList<ST_1ebe89bcb89e874288df8fa96ba9996fStructure>, IEnumerable, IEnumerator {

protected override ST_1ebe89bcb89e874288df8fa96ba9996fStructure GetElementDefaultValue() {
return new ST_1ebe89bcb89e874288df8fa96ba9996fStructure();
}

public T[] ToArray<T>(Func<ST_1ebe89bcb89e874288df8fa96ba9996fStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9f464d3e6033d129f48cd86ef45da46f recordList, Func<ST_1ebe89bcb89e874288df8fa96ba9996fStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9f464d3e6033d129f48cd86ef45da46f(ST_1ebe89bcb89e874288df8fa96ba9996fStructure[] array) {
  RL_9f464d3e6033d129f48cd86ef45da46f result = new RL_9f464d3e6033d129f48cd86ef45da46f();
result.InnerFromArray(array);
    return result;
}

public static RL_9f464d3e6033d129f48cd86ef45da46f ToList<T>(T[] array, Func <T, ST_1ebe89bcb89e874288df8fa96ba9996fStructure> converter) {
  RL_9f464d3e6033d129f48cd86ef45da46f result = new RL_9f464d3e6033d129f48cd86ef45da46f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9f464d3e6033d129f48cd86ef45da46f FromRestList<T>(RestList<T> restList, Func <T, ST_1ebe89bcb89e874288df8fa96ba9996fStructure> converter) {
  RL_9f464d3e6033d129f48cd86ef45da46f result = new RL_9f464d3e6033d129f48cd86ef45da46f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9f464d3e6033d129f48cd86ef45da46f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_1ebe89bcb89e874288df8fa96ba9996fStructure> NewList() {
return new RL_9f464d3e6033d129f48cd86ef45da46f();
}


} // RL_9f464d3e6033d129f48cd86ef45da46f
}

