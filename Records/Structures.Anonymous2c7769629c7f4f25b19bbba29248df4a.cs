namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Yml3LH+cJU+xm7uikkjfSg)
///  <code>RC_e2e47f886a2f72e5f0dffc8728d14117</code> that represent
/// s <code>OrderFileTypesStructRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderFileTypesStructRecord
public partial struct RC_e2e47f886a2f72e5f0dffc8728d14117 : ITypedRecord<RC_e2e47f886a2f72e5f0dffc8728d14117> {
internal static readonly GlobalObjectKey IdOrderFileTypesStruct = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*iH_k4i9q5XLw3_yHKNFBFw");

public ST_c3df6a1f053620bf8d50da58ff4e41bcStructure ssSTOrderFileTypesStruct;


public static implicit operator ST_c3df6a1f053620bf8d50da58ff4e41bcStructure( RC_e2e47f886a2f72e5f0dffc8728d14117 r) {
return r.ssSTOrderFileTypesStruct;
}

public static implicit operator RC_e2e47f886a2f72e5f0dffc8728d14117 (ST_c3df6a1f053620bf8d50da58ff4e41bcStructure r) {
RC_e2e47f886a2f72e5f0dffc8728d14117 res = new RC_e2e47f886a2f72e5f0dffc8728d14117 ();
res.ssSTOrderFileTypesStruct = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_e2e47f886a2f72e5f0dffc8728d14117() {
OptimizedAttributes = null;
ssSTOrderFileTypesStruct = new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure();
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
    ssSTOrderFileTypesStruct.OptimizedAttributes = value[0];
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
ssSTOrderFileTypesStruct.Read( r, ref index);
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
public void ReadIM(RC_e2e47f886a2f72e5f0dffc8728d14117 r) {
this = r;
}


public static bool operator == (RC_e2e47f886a2f72e5f0dffc8728d14117 a, RC_e2e47f886a2f72e5f0dffc8728d14117 b) {
if (a.ssSTOrderFileTypesStruct != b.ssSTOrderFileTypesStruct) return false;
return true;
}

public static bool operator != (RC_e2e47f886a2f72e5f0dffc8728d14117 a, RC_e2e47f886a2f72e5f0dffc8728d14117 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e2e47f886a2f72e5f0dffc8728d14117)) return false;
return (this == (RC_e2e47f886a2f72e5f0dffc8728d14117)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTOrderFileTypesStruct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTOrderFileTypesStruct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTOrderFileTypesStruct.InternalRecursiveSave();
}


public RC_e2e47f886a2f72e5f0dffc8728d14117 Duplicate() {
RC_e2e47f886a2f72e5f0dffc8728d14117 t;
t.ssSTOrderFileTypesStruct = (ST_c3df6a1f053620bf8d50da58ff4e41bcStructure)this.ssSTOrderFileTypesStruct.Duplicate();
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
if (head == "orderfiletypesstruct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderFileTypesStruct")) variable.Value = ssSTOrderFileTypesStruct; else variable.Optimized = true;
variable.SetFieldName("orderfiletypesstruct");
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
if (key == IdOrderFileTypesStruct) {
return ssSTOrderFileTypesStruct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderFileTypesStruct.Key.AsGuid) {
return ssSTOrderFileTypesStruct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTOrderFileTypesStruct.FillFromOther((IRecord) other.AttributeGet(IdOrderFileTypesStruct));
}
} // RC_e2e47f886a2f72e5f0dffc8728d14117
/// <summary>
/// RecordList type <code>OrderFileTypesStructRecordList</code> that represents a record list of
///  <code>OrderFileTypesStruct</code>
/// </summary>
public partial class RL_e0f837d40fdc8ee4e0ec0a744632069b : GenericRecordList<RC_e2e47f886a2f72e5f0dffc8728d14117>, IEnumerable, IEnumerator {

protected override RC_e2e47f886a2f72e5f0dffc8728d14117 GetElementDefaultValue() {
return new RC_e2e47f886a2f72e5f0dffc8728d14117();
}

public T[] ToArray<T>(Func<RC_e2e47f886a2f72e5f0dffc8728d14117, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e0f837d40fdc8ee4e0ec0a744632069b recordList, Func<RC_e2e47f886a2f72e5f0dffc8728d14117, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e0f837d40fdc8ee4e0ec0a744632069b(RC_e2e47f886a2f72e5f0dffc8728d14117[] array) {
  RL_e0f837d40fdc8ee4e0ec0a744632069b result = new RL_e0f837d40fdc8ee4e0ec0a744632069b();
result.InnerFromArray(array);
    return result;
}

public static RL_e0f837d40fdc8ee4e0ec0a744632069b ToList<T>(T[] array, Func <T, RC_e2e47f886a2f72e5f0dffc8728d14117> converter) {
  RL_e0f837d40fdc8ee4e0ec0a744632069b result = new RL_e0f837d40fdc8ee4e0ec0a744632069b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e0f837d40fdc8ee4e0ec0a744632069b FromRestList<T>(RestList<T> restList, Func <T, RC_e2e47f886a2f72e5f0dffc8728d14117> converter) {
  RL_e0f837d40fdc8ee4e0ec0a744632069b result = new RL_e0f837d40fdc8ee4e0ec0a744632069b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e0f837d40fdc8ee4e0ec0a744632069b() : base() {
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
protected override OSList<RC_e2e47f886a2f72e5f0dffc8728d14117> NewList() {
return new RL_e0f837d40fdc8ee4e0ec0a744632069b();
}


} // RL_e0f837d40fdc8ee4e0ec0a744632069b
}

