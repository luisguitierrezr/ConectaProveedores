namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (QyZIgk1lMkKZ8dGDa16xJQ)
///  <code>RC_5506eaadd5156d49feef98fb7105f829</code> that represents <code>T_FAC_PAG_OutRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: T_FAC_PAG_OutRecord
public partial struct RC_5506eaadd5156d49feef98fb7105f829 : ITypedRecord<RC_5506eaadd5156d49feef98fb7105f829> {
internal static readonly GlobalObjectKey IdT_FAC_PAG_Out = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*reoGVRXVSW3+75j7cQX4KQ");

public ST_99acd807840db0272ca95b7e5ca3fca1Structure ssSTT_FAC_PAG_Out;


public static implicit operator ST_99acd807840db0272ca95b7e5ca3fca1Structure( RC_5506eaadd5156d49feef98fb7105f829 r) {
return r.ssSTT_FAC_PAG_Out;
}

public static implicit operator RC_5506eaadd5156d49feef98fb7105f829 (ST_99acd807840db0272ca95b7e5ca3fca1Structure r) {
RC_5506eaadd5156d49feef98fb7105f829 res = new RC_5506eaadd5156d49feef98fb7105f829 ();
res.ssSTT_FAC_PAG_Out = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_5506eaadd5156d49feef98fb7105f829() {
OptimizedAttributes = null;
ssSTT_FAC_PAG_Out = new ST_99acd807840db0272ca95b7e5ca3fca1Structure();
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
    ssSTT_FAC_PAG_Out.OptimizedAttributes = value[0];
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
ssSTT_FAC_PAG_Out.Read( r, ref index);
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
public void ReadIM(RC_5506eaadd5156d49feef98fb7105f829 r) {
this = r;
}


public static bool operator == (RC_5506eaadd5156d49feef98fb7105f829 a, RC_5506eaadd5156d49feef98fb7105f829 b) {
if (a.ssSTT_FAC_PAG_Out != b.ssSTT_FAC_PAG_Out) return false;
return true;
}

public static bool operator != (RC_5506eaadd5156d49feef98fb7105f829 a, RC_5506eaadd5156d49feef98fb7105f829 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_5506eaadd5156d49feef98fb7105f829)) return false;
return (this == (RC_5506eaadd5156d49feef98fb7105f829)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTT_FAC_PAG_Out.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTT_FAC_PAG_Out.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTT_FAC_PAG_Out.InternalRecursiveSave();
}


public RC_5506eaadd5156d49feef98fb7105f829 Duplicate() {
RC_5506eaadd5156d49feef98fb7105f829 t;
t.ssSTT_FAC_PAG_Out = (ST_99acd807840db0272ca95b7e5ca3fca1Structure)this.ssSTT_FAC_PAG_Out.Duplicate();
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
if (head == "t_fac_pag_out") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".T_FAC_PAG_Out")) variable.Value = ssSTT_FAC_PAG_Out; else variable.Optimized = true;
variable.SetFieldName("t_fac_pag_out");
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
if (key == IdT_FAC_PAG_Out) {
return ssSTT_FAC_PAG_Out;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdT_FAC_PAG_Out.Key.AsGuid) {
return ssSTT_FAC_PAG_Out;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTT_FAC_PAG_Out.FillFromOther((IRecord) other.AttributeGet(IdT_FAC_PAG_Out));
}
} // RC_5506eaadd5156d49feef98fb7105f829
/// <summary>
/// RecordList type <code>T_FAC_PAG_OutRecordList</code> that represents a record list of
///  <code>T_FAC_PAG_Out</code>
/// </summary>
public partial class RL_20cb2ff36c72ee4fdbdb41d108f15139 : GenericRecordList<RC_5506eaadd5156d49feef98fb7105f829>, IEnumerable, IEnumerator {

protected override RC_5506eaadd5156d49feef98fb7105f829 GetElementDefaultValue() {
return new RC_5506eaadd5156d49feef98fb7105f829();
}

public T[] ToArray<T>(Func<RC_5506eaadd5156d49feef98fb7105f829, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_20cb2ff36c72ee4fdbdb41d108f15139 recordList, Func<RC_5506eaadd5156d49feef98fb7105f829, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_20cb2ff36c72ee4fdbdb41d108f15139(RC_5506eaadd5156d49feef98fb7105f829[] array) {
  RL_20cb2ff36c72ee4fdbdb41d108f15139 result = new RL_20cb2ff36c72ee4fdbdb41d108f15139();
result.InnerFromArray(array);
    return result;
}

public static RL_20cb2ff36c72ee4fdbdb41d108f15139 ToList<T>(T[] array, Func <T, RC_5506eaadd5156d49feef98fb7105f829> converter) {
  RL_20cb2ff36c72ee4fdbdb41d108f15139 result = new RL_20cb2ff36c72ee4fdbdb41d108f15139();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_20cb2ff36c72ee4fdbdb41d108f15139 FromRestList<T>(RestList<T> restList, Func <T, RC_5506eaadd5156d49feef98fb7105f829> converter) {
  RL_20cb2ff36c72ee4fdbdb41d108f15139 result = new RL_20cb2ff36c72ee4fdbdb41d108f15139();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_20cb2ff36c72ee4fdbdb41d108f15139() : base() {
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
protected override OSList<RC_5506eaadd5156d49feef98fb7105f829> NewList() {
return new RL_20cb2ff36c72ee4fdbdb41d108f15139();
}


} // RL_20cb2ff36c72ee4fdbdb41d108f15139
}

