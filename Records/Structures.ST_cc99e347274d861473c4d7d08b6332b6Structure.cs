namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] Z01_READ_TEXTResp (if+vwoE_GU+tVh3gRcczDA)
///  <code>ST_cc99e347274d861473c4d7d08b6332b6Structure</code> that represent
/// s <code>Z01_READ_TEXTResp</code> <p>Description: Z01_READ_TEXTResp</p>
/// </summary>
// Name: Z01_READ_TEXTResp
public partial struct ST_cc99e347274d861473c4d7d08b6332b6Structure : ITypedRecord<ST_cc99e347274d861473c4d7d08b6332b6Structure> {
internal static readonly GlobalObjectKey IdLINES = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*e9ltxy_Whk+YAzAoVCjzOw");

public RL_9f464d3e6033d129f48cd86ef45da46f ssLINES;


public BitArray OptimizedAttributes;

public ST_cc99e347274d861473c4d7d08b6332b6Structure() {
OptimizedAttributes = null;
ssLINES = new RL_9f464d3e6033d129f48cd86ef45da46f();
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
public void ReadIM(ST_cc99e347274d861473c4d7d08b6332b6Structure r) {
this = r;
}


public static bool operator == (ST_cc99e347274d861473c4d7d08b6332b6Structure a, ST_cc99e347274d861473c4d7d08b6332b6Structure b) {
if (a.ssLINES != b.ssLINES) return false;
return true;
}

public static bool operator != (ST_cc99e347274d861473c4d7d08b6332b6Structure a, ST_cc99e347274d861473c4d7d08b6332b6Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_cc99e347274d861473c4d7d08b6332b6Structure)) return false;
return (this == (ST_cc99e347274d861473c4d7d08b6332b6Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssLINES.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssLINES.RecursiveReset();
}

public void InternalRecursiveSave() {
ssLINES.InternalRecursiveSave();
}


public ST_cc99e347274d861473c4d7d08b6332b6Structure Duplicate() {
ST_cc99e347274d861473c4d7d08b6332b6Structure t;
t.ssLINES = (RL_9f464d3e6033d129f48cd86ef45da46f)this.ssLINES.Duplicate();
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
if (head == "lines") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LINES")) variable.Value = ssLINES; else variable.Optimized = true;
variable.SetFieldName("lines");
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
if (key == IdLINES) {
return ssLINES;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdLINES.Key.AsGuid) {
return ssLINES;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssLINES = new RL_9f464d3e6033d129f48cd86ef45da46f();
ssLINES.FillFromOther((IOSList) other.AttributeGet(IdLINES));
}
} // ST_cc99e347274d861473c4d7d08b6332b6Structure
/// <summary>
/// RecordList type <code>Z01_READ_TEXTRespList</code> that represents a record list of
///  <code>Z01_READ_TEXTResp</code>
/// </summary>
public partial class RL_6628acc6d51bed055b37a328739e81da : GenericRecordList<ST_cc99e347274d861473c4d7d08b6332b6Structure>, IEnumerable, IEnumerator {

protected override ST_cc99e347274d861473c4d7d08b6332b6Structure GetElementDefaultValue() {
return new ST_cc99e347274d861473c4d7d08b6332b6Structure();
}

public T[] ToArray<T>(Func<ST_cc99e347274d861473c4d7d08b6332b6Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6628acc6d51bed055b37a328739e81da recordList, Func<ST_cc99e347274d861473c4d7d08b6332b6Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6628acc6d51bed055b37a328739e81da(ST_cc99e347274d861473c4d7d08b6332b6Structure[] array) {
  RL_6628acc6d51bed055b37a328739e81da result = new RL_6628acc6d51bed055b37a328739e81da();
result.InnerFromArray(array);
    return result;
}

public static RL_6628acc6d51bed055b37a328739e81da ToList<T>(T[] array, Func <T, ST_cc99e347274d861473c4d7d08b6332b6Structure> converter) {
  RL_6628acc6d51bed055b37a328739e81da result = new RL_6628acc6d51bed055b37a328739e81da();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6628acc6d51bed055b37a328739e81da FromRestList<T>(RestList<T> restList, Func <T, ST_cc99e347274d861473c4d7d08b6332b6Structure> converter) {
  RL_6628acc6d51bed055b37a328739e81da result = new RL_6628acc6d51bed055b37a328739e81da();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6628acc6d51bed055b37a328739e81da() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_cc99e347274d861473c4d7d08b6332b6Structure> NewList() {
return new RL_6628acc6d51bed055b37a328739e81da();
}


} // RL_6628acc6d51bed055b37a328739e81da
}

