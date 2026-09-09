namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Eh48HZbHl0uF4jStOoACHA)
///  <code>RC_55b039ad9dadaf85e6b53027c0f314fc</code> that represent
/// s <code>TO_RESULTADO_OutRecord</code> <p>Description: </p>
/// </summary>
// Name: TO_RESULTADO_OutRecord
public partial struct RC_55b039ad9dadaf85e6b53027c0f314fc : ITypedRecord<RC_55b039ad9dadaf85e6b53027c0f314fc> {
internal static readonly GlobalObjectKey IdTO_RESULTADO_Out = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*rTmwVa2dha_mtTAnwPMU_A");

public ST_1ca05235ee87feb8ff9907143d7de852Structure ssSTTO_RESULTADO_Out;


public static implicit operator ST_1ca05235ee87feb8ff9907143d7de852Structure( RC_55b039ad9dadaf85e6b53027c0f314fc r) {
return r.ssSTTO_RESULTADO_Out;
}

public static implicit operator RC_55b039ad9dadaf85e6b53027c0f314fc (ST_1ca05235ee87feb8ff9907143d7de852Structure r) {
RC_55b039ad9dadaf85e6b53027c0f314fc res = new RC_55b039ad9dadaf85e6b53027c0f314fc ();
res.ssSTTO_RESULTADO_Out = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_55b039ad9dadaf85e6b53027c0f314fc() {
OptimizedAttributes = null;
ssSTTO_RESULTADO_Out = new ST_1ca05235ee87feb8ff9907143d7de852Structure();
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
    ssSTTO_RESULTADO_Out.OptimizedAttributes = value[0];
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
ssSTTO_RESULTADO_Out.Read( r, ref index);
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
public void ReadIM(RC_55b039ad9dadaf85e6b53027c0f314fc r) {
this = r;
}


public static bool operator == (RC_55b039ad9dadaf85e6b53027c0f314fc a, RC_55b039ad9dadaf85e6b53027c0f314fc b) {
if (a.ssSTTO_RESULTADO_Out != b.ssSTTO_RESULTADO_Out) return false;
return true;
}

public static bool operator != (RC_55b039ad9dadaf85e6b53027c0f314fc a, RC_55b039ad9dadaf85e6b53027c0f314fc b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_55b039ad9dadaf85e6b53027c0f314fc)) return false;
return (this == (RC_55b039ad9dadaf85e6b53027c0f314fc)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTTO_RESULTADO_Out.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTTO_RESULTADO_Out.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTTO_RESULTADO_Out.InternalRecursiveSave();
}


public RC_55b039ad9dadaf85e6b53027c0f314fc Duplicate() {
RC_55b039ad9dadaf85e6b53027c0f314fc t;
t.ssSTTO_RESULTADO_Out = (ST_1ca05235ee87feb8ff9907143d7de852Structure)this.ssSTTO_RESULTADO_Out.Duplicate();
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
if (head == "to_resultado_out") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TO_RESULTADO_Out")) variable.Value = ssSTTO_RESULTADO_Out; else variable.Optimized = true;
variable.SetFieldName("to_resultado_out");
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
if (key == IdTO_RESULTADO_Out) {
return ssSTTO_RESULTADO_Out;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTO_RESULTADO_Out.Key.AsGuid) {
return ssSTTO_RESULTADO_Out;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTTO_RESULTADO_Out.FillFromOther((IRecord) other.AttributeGet(IdTO_RESULTADO_Out));
}
} // RC_55b039ad9dadaf85e6b53027c0f314fc
/// <summary>
/// RecordList type <code>TO_RESULTADO_OutRecordList</code> that represents a record list of
///  <code>TO_RESULTADO_Out</code>
/// </summary>
public partial class RL_e9cd2a06b2b4b79af695ed57f012a2f1 : GenericRecordList<RC_55b039ad9dadaf85e6b53027c0f314fc>, IEnumerable, IEnumerator {

protected override RC_55b039ad9dadaf85e6b53027c0f314fc GetElementDefaultValue() {
return new RC_55b039ad9dadaf85e6b53027c0f314fc();
}

public T[] ToArray<T>(Func<RC_55b039ad9dadaf85e6b53027c0f314fc, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e9cd2a06b2b4b79af695ed57f012a2f1 recordList, Func<RC_55b039ad9dadaf85e6b53027c0f314fc, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e9cd2a06b2b4b79af695ed57f012a2f1(RC_55b039ad9dadaf85e6b53027c0f314fc[] array) {
  RL_e9cd2a06b2b4b79af695ed57f012a2f1 result = new RL_e9cd2a06b2b4b79af695ed57f012a2f1();
result.InnerFromArray(array);
    return result;
}

public static RL_e9cd2a06b2b4b79af695ed57f012a2f1 ToList<T>(T[] array, Func <T, RC_55b039ad9dadaf85e6b53027c0f314fc> converter) {
  RL_e9cd2a06b2b4b79af695ed57f012a2f1 result = new RL_e9cd2a06b2b4b79af695ed57f012a2f1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e9cd2a06b2b4b79af695ed57f012a2f1 FromRestList<T>(RestList<T> restList, Func <T, RC_55b039ad9dadaf85e6b53027c0f314fc> converter) {
  RL_e9cd2a06b2b4b79af695ed57f012a2f1 result = new RL_e9cd2a06b2b4b79af695ed57f012a2f1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e9cd2a06b2b4b79af695ed57f012a2f1() : base() {
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
protected override OSList<RC_55b039ad9dadaf85e6b53027c0f314fc> NewList() {
return new RL_e9cd2a06b2b4b79af695ed57f012a2f1();
}


} // RL_e9cd2a06b2b4b79af695ed57f012a2f1
}

