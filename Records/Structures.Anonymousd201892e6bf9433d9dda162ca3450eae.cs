namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (LokB0vlrPUOd2hYso0UOrg)
///  <code>RC_1c505a8024c41aaa0d011f8eb7450033</code> that represent
/// s <code>T_FACT_PEN_PAG_InRecord</code> <p>Description: </p>
/// </summary>
// Name: T_FACT_PEN_PAG_InRecord
public partial struct RC_1c505a8024c41aaa0d011f8eb7450033 : ITypedRecord<RC_1c505a8024c41aaa0d011f8eb7450033> {
internal static readonly GlobalObjectKey IdT_FACT_PEN_PAG_In = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*gFpQHMQkqhoNAR+Ot0UAMw");

public ST_0310bb62d750573571d23e0cd61c55b3Structure ssSTT_FACT_PEN_PAG_In;


public static implicit operator ST_0310bb62d750573571d23e0cd61c55b3Structure( RC_1c505a8024c41aaa0d011f8eb7450033 r) {
return r.ssSTT_FACT_PEN_PAG_In;
}

public static implicit operator RC_1c505a8024c41aaa0d011f8eb7450033 (ST_0310bb62d750573571d23e0cd61c55b3Structure r) {
RC_1c505a8024c41aaa0d011f8eb7450033 res = new RC_1c505a8024c41aaa0d011f8eb7450033 ();
res.ssSTT_FACT_PEN_PAG_In = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_1c505a8024c41aaa0d011f8eb7450033() {
OptimizedAttributes = null;
ssSTT_FACT_PEN_PAG_In = new ST_0310bb62d750573571d23e0cd61c55b3Structure();
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
    ssSTT_FACT_PEN_PAG_In.OptimizedAttributes = value[0];
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
ssSTT_FACT_PEN_PAG_In.Read( r, ref index);
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
public void ReadIM(RC_1c505a8024c41aaa0d011f8eb7450033 r) {
this = r;
}


public static bool operator == (RC_1c505a8024c41aaa0d011f8eb7450033 a, RC_1c505a8024c41aaa0d011f8eb7450033 b) {
if (a.ssSTT_FACT_PEN_PAG_In != b.ssSTT_FACT_PEN_PAG_In) return false;
return true;
}

public static bool operator != (RC_1c505a8024c41aaa0d011f8eb7450033 a, RC_1c505a8024c41aaa0d011f8eb7450033 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_1c505a8024c41aaa0d011f8eb7450033)) return false;
return (this == (RC_1c505a8024c41aaa0d011f8eb7450033)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTT_FACT_PEN_PAG_In.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTT_FACT_PEN_PAG_In.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTT_FACT_PEN_PAG_In.InternalRecursiveSave();
}


public RC_1c505a8024c41aaa0d011f8eb7450033 Duplicate() {
RC_1c505a8024c41aaa0d011f8eb7450033 t;
t.ssSTT_FACT_PEN_PAG_In = (ST_0310bb62d750573571d23e0cd61c55b3Structure)this.ssSTT_FACT_PEN_PAG_In.Duplicate();
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
if (head == "t_fact_pen_pag_in") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".T_FACT_PEN_PAG_In")) variable.Value = ssSTT_FACT_PEN_PAG_In; else variable.Optimized = true;
variable.SetFieldName("t_fact_pen_pag_in");
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
if (key == IdT_FACT_PEN_PAG_In) {
return ssSTT_FACT_PEN_PAG_In;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdT_FACT_PEN_PAG_In.Key.AsGuid) {
return ssSTT_FACT_PEN_PAG_In;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTT_FACT_PEN_PAG_In.FillFromOther((IRecord) other.AttributeGet(IdT_FACT_PEN_PAG_In));
}
} // RC_1c505a8024c41aaa0d011f8eb7450033
/// <summary>
/// RecordList type <code>T_FACT_PEN_PAG_InRecordList</code> that represents a record list of
///  <code>T_FACT_PEN_PAG_In</code>
/// </summary>
public partial class RL_03689c994675b5d37b88d9d6763c241a : GenericRecordList<RC_1c505a8024c41aaa0d011f8eb7450033>, IEnumerable, IEnumerator {

protected override RC_1c505a8024c41aaa0d011f8eb7450033 GetElementDefaultValue() {
return new RC_1c505a8024c41aaa0d011f8eb7450033();
}

public T[] ToArray<T>(Func<RC_1c505a8024c41aaa0d011f8eb7450033, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_03689c994675b5d37b88d9d6763c241a recordList, Func<RC_1c505a8024c41aaa0d011f8eb7450033, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_03689c994675b5d37b88d9d6763c241a(RC_1c505a8024c41aaa0d011f8eb7450033[] array) {
  RL_03689c994675b5d37b88d9d6763c241a result = new RL_03689c994675b5d37b88d9d6763c241a();
result.InnerFromArray(array);
    return result;
}

public static RL_03689c994675b5d37b88d9d6763c241a ToList<T>(T[] array, Func <T, RC_1c505a8024c41aaa0d011f8eb7450033> converter) {
  RL_03689c994675b5d37b88d9d6763c241a result = new RL_03689c994675b5d37b88d9d6763c241a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_03689c994675b5d37b88d9d6763c241a FromRestList<T>(RestList<T> restList, Func <T, RC_1c505a8024c41aaa0d011f8eb7450033> converter) {
  RL_03689c994675b5d37b88d9d6763c241a result = new RL_03689c994675b5d37b88d9d6763c241a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_03689c994675b5d37b88d9d6763c241a() : base() {
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
protected override OSList<RC_1c505a8024c41aaa0d011f8eb7450033> NewList() {
return new RL_03689c994675b5d37b88d9d6763c241a();
}


} // RL_03689c994675b5d37b88d9d6763c241a
}

