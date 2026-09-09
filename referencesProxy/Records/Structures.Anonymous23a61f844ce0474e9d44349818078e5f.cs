namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (hB+mI+BMTkedRDSYGAeOXw)
///  <code>RC_11e12158254e5be6bde5f4ba88bacb32</code> that represent
/// s <code>ChartLegendStylingRecord</code> <p>Description: </p>
/// </summary>
// Name: ChartLegendStylingRecord
public partial struct RC_11e12158254e5be6bde5f4ba88bacb32 : ITypedRecord<RC_11e12158254e5be6bde5f4ba88bacb32> {
internal static readonly GlobalObjectKey IdChartLegendStyling = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*WCHhEU4l5lu95fS6iLrLMg");

public ST_4bdf4d0ba65c5e31172d7b508a740391Structure ssSTChartLegendStyling;


public static implicit operator ST_4bdf4d0ba65c5e31172d7b508a740391Structure( RC_11e12158254e5be6bde5f4ba88bacb32 r) {
return r.ssSTChartLegendStyling;
}

public static implicit operator RC_11e12158254e5be6bde5f4ba88bacb32 (ST_4bdf4d0ba65c5e31172d7b508a740391Structure r) {
RC_11e12158254e5be6bde5f4ba88bacb32 res = new RC_11e12158254e5be6bde5f4ba88bacb32 ();
res.ssSTChartLegendStyling = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_11e12158254e5be6bde5f4ba88bacb32() {
OptimizedAttributes = null;
ssSTChartLegendStyling = new ST_4bdf4d0ba65c5e31172d7b508a740391Structure();
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
    ssSTChartLegendStyling.OptimizedAttributes = value[0];
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
ssSTChartLegendStyling.Read( r, ref index);
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
public void ReadIM(RC_11e12158254e5be6bde5f4ba88bacb32 r) {
this = r;
}


public static bool operator == (RC_11e12158254e5be6bde5f4ba88bacb32 a, RC_11e12158254e5be6bde5f4ba88bacb32 b) {
if (a.ssSTChartLegendStyling != b.ssSTChartLegendStyling) return false;
return true;
}

public static bool operator != (RC_11e12158254e5be6bde5f4ba88bacb32 a, RC_11e12158254e5be6bde5f4ba88bacb32 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_11e12158254e5be6bde5f4ba88bacb32)) return false;
return (this == (RC_11e12158254e5be6bde5f4ba88bacb32)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTChartLegendStyling.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTChartLegendStyling.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTChartLegendStyling.InternalRecursiveSave();
}


public RC_11e12158254e5be6bde5f4ba88bacb32 Duplicate() {
RC_11e12158254e5be6bde5f4ba88bacb32 t;
t.ssSTChartLegendStyling = (ST_4bdf4d0ba65c5e31172d7b508a740391Structure)this.ssSTChartLegendStyling.Duplicate();
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
if (head == "chartlegendstyling") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ChartLegendStyling")) variable.Value = ssSTChartLegendStyling; else variable.Optimized = true;
variable.SetFieldName("chartlegendstyling");
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
if (key == IdChartLegendStyling) {
return ssSTChartLegendStyling;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdChartLegendStyling.Key.AsGuid) {
return ssSTChartLegendStyling;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTChartLegendStyling.FillFromOther((IRecord) other.AttributeGet(IdChartLegendStyling));
}
} // RC_11e12158254e5be6bde5f4ba88bacb32
/// <summary>
/// RecordList type <code>ChartLegendStylingRecordList</code> that represents a record list of
///  <code>ChartLegendStyling</code>
/// </summary>
public partial class RL_99477c70990b1c5bac51f37a012521f9 : GenericRecordList<RC_11e12158254e5be6bde5f4ba88bacb32>, IEnumerable, IEnumerator {

protected override RC_11e12158254e5be6bde5f4ba88bacb32 GetElementDefaultValue() {
return new RC_11e12158254e5be6bde5f4ba88bacb32();
}

public T[] ToArray<T>(Func<RC_11e12158254e5be6bde5f4ba88bacb32, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_99477c70990b1c5bac51f37a012521f9 recordList, Func<RC_11e12158254e5be6bde5f4ba88bacb32, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_99477c70990b1c5bac51f37a012521f9(RC_11e12158254e5be6bde5f4ba88bacb32[] array) {
  RL_99477c70990b1c5bac51f37a012521f9 result = new RL_99477c70990b1c5bac51f37a012521f9();
result.InnerFromArray(array);
    return result;
}

public static RL_99477c70990b1c5bac51f37a012521f9 ToList<T>(T[] array, Func <T, RC_11e12158254e5be6bde5f4ba88bacb32> converter) {
  RL_99477c70990b1c5bac51f37a012521f9 result = new RL_99477c70990b1c5bac51f37a012521f9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_99477c70990b1c5bac51f37a012521f9 FromRestList<T>(RestList<T> restList, Func <T, RC_11e12158254e5be6bde5f4ba88bacb32> converter) {
  RL_99477c70990b1c5bac51f37a012521f9 result = new RL_99477c70990b1c5bac51f37a012521f9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_99477c70990b1c5bac51f37a012521f9() : base() {
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
protected override OSList<RC_11e12158254e5be6bde5f4ba88bacb32> NewList() {
return new RL_99477c70990b1c5bac51f37a012521f9();
}


} // RL_99477c70990b1c5bac51f37a012521f9
}

