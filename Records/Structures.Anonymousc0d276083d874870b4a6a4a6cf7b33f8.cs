namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (CHbSwIc9cEi0pqSmz3sz+A)
///  <code>RC_649e4584946d534f750cbe1a016bfe86</code> that represents <code>LinesReport62Record</code
/// > <p>Description: </p>
/// </summary>
// Name: LinesReport62Record
public partial struct RC_649e4584946d534f750cbe1a016bfe86 : ITypedRecord<RC_649e4584946d534f750cbe1a016bfe86> {
internal static readonly GlobalObjectKey IdLinesReport62 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*hEWeZG2UT1N1DL4aAWv+hg");

public ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure ssSTLinesReport62;


public static implicit operator ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure( RC_649e4584946d534f750cbe1a016bfe86 r) {
return r.ssSTLinesReport62;
}

public static implicit operator RC_649e4584946d534f750cbe1a016bfe86 (ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure r) {
RC_649e4584946d534f750cbe1a016bfe86 res = new RC_649e4584946d534f750cbe1a016bfe86 ();
res.ssSTLinesReport62 = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_649e4584946d534f750cbe1a016bfe86() {
OptimizedAttributes = null;
ssSTLinesReport62 = new ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTLinesReport62.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTLinesReport62.Read( r, ref index);
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
public void ReadIM(RC_649e4584946d534f750cbe1a016bfe86 r) {
this = r;
}


public static bool operator == (RC_649e4584946d534f750cbe1a016bfe86 a, RC_649e4584946d534f750cbe1a016bfe86 b) {
if (a.ssSTLinesReport62 != b.ssSTLinesReport62) return false;
return true;
}

public static bool operator != (RC_649e4584946d534f750cbe1a016bfe86 a, RC_649e4584946d534f750cbe1a016bfe86 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_649e4584946d534f750cbe1a016bfe86)) return false;
return (this == (RC_649e4584946d534f750cbe1a016bfe86)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTLinesReport62.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTLinesReport62.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTLinesReport62.InternalRecursiveSave();
}


public RC_649e4584946d534f750cbe1a016bfe86 Duplicate() {
RC_649e4584946d534f750cbe1a016bfe86 t;
t.ssSTLinesReport62 = (ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure)this.ssSTLinesReport62.Duplicate();
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
if (head == "linesreport62") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LinesReport62")) variable.Value = ssSTLinesReport62; else variable.Optimized = true;
variable.SetFieldName("linesreport62");
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
if (key == IdLinesReport62) {
return ssSTLinesReport62;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdLinesReport62.Key.AsGuid) {
return ssSTLinesReport62;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTLinesReport62.FillFromOther((IRecord) other.AttributeGet(IdLinesReport62));
}
} // RC_649e4584946d534f750cbe1a016bfe86
/// <summary>
/// RecordList type <code>LinesReport62RecordList</code> that represents a record list of
///  <code>LinesReport62</code>
/// </summary>
public partial class RL_08a3cab14d848e9f5ed6e13d98f51a9c : GenericRecordList<RC_649e4584946d534f750cbe1a016bfe86>, IEnumerable, IEnumerator {

protected override RC_649e4584946d534f750cbe1a016bfe86 GetElementDefaultValue() {
return new RC_649e4584946d534f750cbe1a016bfe86();
}

public T[] ToArray<T>(Func<RC_649e4584946d534f750cbe1a016bfe86, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_08a3cab14d848e9f5ed6e13d98f51a9c recordList, Func<RC_649e4584946d534f750cbe1a016bfe86, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_08a3cab14d848e9f5ed6e13d98f51a9c(RC_649e4584946d534f750cbe1a016bfe86[] array) {
  RL_08a3cab14d848e9f5ed6e13d98f51a9c result = new RL_08a3cab14d848e9f5ed6e13d98f51a9c();
result.InnerFromArray(array);
    return result;
}

public static RL_08a3cab14d848e9f5ed6e13d98f51a9c ToList<T>(T[] array, Func <T, RC_649e4584946d534f750cbe1a016bfe86> converter) {
  RL_08a3cab14d848e9f5ed6e13d98f51a9c result = new RL_08a3cab14d848e9f5ed6e13d98f51a9c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_08a3cab14d848e9f5ed6e13d98f51a9c FromRestList<T>(RestList<T> restList, Func <T, RC_649e4584946d534f750cbe1a016bfe86> converter) {
  RL_08a3cab14d848e9f5ed6e13d98f51a9c result = new RL_08a3cab14d848e9f5ed6e13d98f51a9c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_08a3cab14d848e9f5ed6e13d98f51a9c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_649e4584946d534f750cbe1a016bfe86> NewList() {
return new RL_08a3cab14d848e9f5ed6e13d98f51a9c();
}


} // RL_08a3cab14d848e9f5ed6e13d98f51a9c
}

