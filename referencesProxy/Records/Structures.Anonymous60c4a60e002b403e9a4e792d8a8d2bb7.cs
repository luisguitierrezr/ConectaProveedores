namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (DqbEYCsAPkCaTnktio0rtw)
///  <code>RC_c38769c4e3f53c55790e6a4b2c81b7ff</code> that represent
/// s <code>ChartLegendOptionalConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: ChartLegendOptionalConfigsRecord
public partial struct RC_c38769c4e3f53c55790e6a4b2c81b7ff : ITypedRecord<RC_c38769c4e3f53c55790e6a4b2c81b7ff> {
internal static readonly GlobalObjectKey IdChartLegendOptionalConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xGmHw_XjVTx5DmpLLIG3_w");

public ST_24000c8fde24da45a0d83940a64dbbafStructure ssSTChartLegendOptionalConfigs;


public static implicit operator ST_24000c8fde24da45a0d83940a64dbbafStructure( RC_c38769c4e3f53c55790e6a4b2c81b7ff r) {
return r.ssSTChartLegendOptionalConfigs;
}

public static implicit operator RC_c38769c4e3f53c55790e6a4b2c81b7ff (ST_24000c8fde24da45a0d83940a64dbbafStructure r) {
RC_c38769c4e3f53c55790e6a4b2c81b7ff res = new RC_c38769c4e3f53c55790e6a4b2c81b7ff ();
res.ssSTChartLegendOptionalConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_c38769c4e3f53c55790e6a4b2c81b7ff() {
OptimizedAttributes = null;
ssSTChartLegendOptionalConfigs = new ST_24000c8fde24da45a0d83940a64dbbafStructure();
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
    ssSTChartLegendOptionalConfigs.OptimizedAttributes = value[0];
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
ssSTChartLegendOptionalConfigs.Read( r, ref index);
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
public void ReadIM(RC_c38769c4e3f53c55790e6a4b2c81b7ff r) {
this = r;
}


public static bool operator == (RC_c38769c4e3f53c55790e6a4b2c81b7ff a, RC_c38769c4e3f53c55790e6a4b2c81b7ff b) {
if (a.ssSTChartLegendOptionalConfigs != b.ssSTChartLegendOptionalConfigs) return false;
return true;
}

public static bool operator != (RC_c38769c4e3f53c55790e6a4b2c81b7ff a, RC_c38769c4e3f53c55790e6a4b2c81b7ff b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c38769c4e3f53c55790e6a4b2c81b7ff)) return false;
return (this == (RC_c38769c4e3f53c55790e6a4b2c81b7ff)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTChartLegendOptionalConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTChartLegendOptionalConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTChartLegendOptionalConfigs.InternalRecursiveSave();
}


public RC_c38769c4e3f53c55790e6a4b2c81b7ff Duplicate() {
RC_c38769c4e3f53c55790e6a4b2c81b7ff t;
t.ssSTChartLegendOptionalConfigs = (ST_24000c8fde24da45a0d83940a64dbbafStructure)this.ssSTChartLegendOptionalConfigs.Duplicate();
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
if (head == "chartlegendoptionalconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ChartLegendOptionalConfigs")) variable.Value = ssSTChartLegendOptionalConfigs; else variable.Optimized = true;
variable.SetFieldName("chartlegendoptionalconfigs");
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
if (key == IdChartLegendOptionalConfigs) {
return ssSTChartLegendOptionalConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdChartLegendOptionalConfigs.Key.AsGuid) {
return ssSTChartLegendOptionalConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTChartLegendOptionalConfigs.FillFromOther((IRecord) other.AttributeGet(IdChartLegendOptionalConfigs));
}
} // RC_c38769c4e3f53c55790e6a4b2c81b7ff
/// <summary>
/// RecordList type <code>ChartLegendOptionalConfigsRecordList</code> that represents a record list of
///  <code>ChartLegendOptionalConfigs</code>
/// </summary>
public partial class RL_0f73e10e5d9541713603d0a98a57b9d8 : GenericRecordList<RC_c38769c4e3f53c55790e6a4b2c81b7ff>, IEnumerable, IEnumerator {

protected override RC_c38769c4e3f53c55790e6a4b2c81b7ff GetElementDefaultValue() {
return new RC_c38769c4e3f53c55790e6a4b2c81b7ff();
}

public T[] ToArray<T>(Func<RC_c38769c4e3f53c55790e6a4b2c81b7ff, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0f73e10e5d9541713603d0a98a57b9d8 recordList, Func<RC_c38769c4e3f53c55790e6a4b2c81b7ff, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0f73e10e5d9541713603d0a98a57b9d8(RC_c38769c4e3f53c55790e6a4b2c81b7ff[] array) {
  RL_0f73e10e5d9541713603d0a98a57b9d8 result = new RL_0f73e10e5d9541713603d0a98a57b9d8();
result.InnerFromArray(array);
    return result;
}

public static RL_0f73e10e5d9541713603d0a98a57b9d8 ToList<T>(T[] array, Func <T, RC_c38769c4e3f53c55790e6a4b2c81b7ff> converter) {
  RL_0f73e10e5d9541713603d0a98a57b9d8 result = new RL_0f73e10e5d9541713603d0a98a57b9d8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0f73e10e5d9541713603d0a98a57b9d8 FromRestList<T>(RestList<T> restList, Func <T, RC_c38769c4e3f53c55790e6a4b2c81b7ff> converter) {
  RL_0f73e10e5d9541713603d0a98a57b9d8 result = new RL_0f73e10e5d9541713603d0a98a57b9d8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0f73e10e5d9541713603d0a98a57b9d8() : base() {
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
protected override OSList<RC_c38769c4e3f53c55790e6a4b2c81b7ff> NewList() {
return new RL_0f73e10e5d9541713603d0a98a57b9d8();
}


} // RL_0f73e10e5d9541713603d0a98a57b9d8
}

