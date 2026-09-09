namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (6qc1ohfga0aUHF244flMgg)
///  <code>RC_4211d0c81727d9df025d8205e67ad09b</code> that represent
/// s <code>T_FACT_PEN_PAG_OutRecord</code> <p>Description: </p>
/// </summary>
// Name: T_FACT_PEN_PAG_OutRecord
public partial struct RC_4211d0c81727d9df025d8205e67ad09b : ITypedRecord<RC_4211d0c81727d9df025d8205e67ad09b> {
internal static readonly GlobalObjectKey IdT_FACT_PEN_PAG_Out = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*yNARQicX39kCXYIF5nrQmw");

public ST_9f44b824af1405b8fbe038a5a393bb86Structure ssSTT_FACT_PEN_PAG_Out;


public static implicit operator ST_9f44b824af1405b8fbe038a5a393bb86Structure( RC_4211d0c81727d9df025d8205e67ad09b r) {
return r.ssSTT_FACT_PEN_PAG_Out;
}

public static implicit operator RC_4211d0c81727d9df025d8205e67ad09b (ST_9f44b824af1405b8fbe038a5a393bb86Structure r) {
RC_4211d0c81727d9df025d8205e67ad09b res = new RC_4211d0c81727d9df025d8205e67ad09b ();
res.ssSTT_FACT_PEN_PAG_Out = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_4211d0c81727d9df025d8205e67ad09b() {
OptimizedAttributes = null;
ssSTT_FACT_PEN_PAG_Out = new ST_9f44b824af1405b8fbe038a5a393bb86Structure();
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
    ssSTT_FACT_PEN_PAG_Out.OptimizedAttributes = value[0];
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
ssSTT_FACT_PEN_PAG_Out.Read( r, ref index);
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
public void ReadIM(RC_4211d0c81727d9df025d8205e67ad09b r) {
this = r;
}


public static bool operator == (RC_4211d0c81727d9df025d8205e67ad09b a, RC_4211d0c81727d9df025d8205e67ad09b b) {
if (a.ssSTT_FACT_PEN_PAG_Out != b.ssSTT_FACT_PEN_PAG_Out) return false;
return true;
}

public static bool operator != (RC_4211d0c81727d9df025d8205e67ad09b a, RC_4211d0c81727d9df025d8205e67ad09b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_4211d0c81727d9df025d8205e67ad09b)) return false;
return (this == (RC_4211d0c81727d9df025d8205e67ad09b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTT_FACT_PEN_PAG_Out.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTT_FACT_PEN_PAG_Out.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTT_FACT_PEN_PAG_Out.InternalRecursiveSave();
}


public RC_4211d0c81727d9df025d8205e67ad09b Duplicate() {
RC_4211d0c81727d9df025d8205e67ad09b t;
t.ssSTT_FACT_PEN_PAG_Out = (ST_9f44b824af1405b8fbe038a5a393bb86Structure)this.ssSTT_FACT_PEN_PAG_Out.Duplicate();
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
if (head == "t_fact_pen_pag_out") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".T_FACT_PEN_PAG_Out")) variable.Value = ssSTT_FACT_PEN_PAG_Out; else variable.Optimized = true;
variable.SetFieldName("t_fact_pen_pag_out");
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
if (key == IdT_FACT_PEN_PAG_Out) {
return ssSTT_FACT_PEN_PAG_Out;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdT_FACT_PEN_PAG_Out.Key.AsGuid) {
return ssSTT_FACT_PEN_PAG_Out;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTT_FACT_PEN_PAG_Out.FillFromOther((IRecord) other.AttributeGet(IdT_FACT_PEN_PAG_Out));
}
} // RC_4211d0c81727d9df025d8205e67ad09b
/// <summary>
/// RecordList type <code>T_FACT_PEN_PAG_OutRecordList</code> that represents a record list of
///  <code>T_FACT_PEN_PAG_Out</code>
/// </summary>
public partial class RL_ae1dad82835b9b0676e945b83b1aba4f : GenericRecordList<RC_4211d0c81727d9df025d8205e67ad09b>, IEnumerable, IEnumerator {

protected override RC_4211d0c81727d9df025d8205e67ad09b GetElementDefaultValue() {
return new RC_4211d0c81727d9df025d8205e67ad09b();
}

public T[] ToArray<T>(Func<RC_4211d0c81727d9df025d8205e67ad09b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ae1dad82835b9b0676e945b83b1aba4f recordList, Func<RC_4211d0c81727d9df025d8205e67ad09b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ae1dad82835b9b0676e945b83b1aba4f(RC_4211d0c81727d9df025d8205e67ad09b[] array) {
  RL_ae1dad82835b9b0676e945b83b1aba4f result = new RL_ae1dad82835b9b0676e945b83b1aba4f();
result.InnerFromArray(array);
    return result;
}

public static RL_ae1dad82835b9b0676e945b83b1aba4f ToList<T>(T[] array, Func <T, RC_4211d0c81727d9df025d8205e67ad09b> converter) {
  RL_ae1dad82835b9b0676e945b83b1aba4f result = new RL_ae1dad82835b9b0676e945b83b1aba4f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ae1dad82835b9b0676e945b83b1aba4f FromRestList<T>(RestList<T> restList, Func <T, RC_4211d0c81727d9df025d8205e67ad09b> converter) {
  RL_ae1dad82835b9b0676e945b83b1aba4f result = new RL_ae1dad82835b9b0676e945b83b1aba4f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ae1dad82835b9b0676e945b83b1aba4f() : base() {
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
protected override OSList<RC_4211d0c81727d9df025d8205e67ad09b> NewList() {
return new RL_ae1dad82835b9b0676e945b83b1aba4f();
}


} // RL_ae1dad82835b9b0676e945b83b1aba4f
}

