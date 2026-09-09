namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (bmRfrR4eYkaKvG3m1luRfw)
///  <code>RC_0e8dad36985178676a96cdacdf6f5259</code> that represent
/// s <code>OrderDistributionImportStrucRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderDistributionImportStrucRecord
public partial struct RC_0e8dad36985178676a96cdacdf6f5259 : ITypedRecord<RC_0e8dad36985178676a96cdacdf6f5259> {
internal static readonly GlobalObjectKey IdOrderDistributionImportStruc = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Nq2NDlGYZ3hqls2s329SWQ");

public ST_eeea109a56651eacd7e36d2408b5b781Structure ssSTOrderDistributionImportStruc;


public static implicit operator ST_eeea109a56651eacd7e36d2408b5b781Structure( RC_0e8dad36985178676a96cdacdf6f5259 r) {
return r.ssSTOrderDistributionImportStruc;
}

public static implicit operator RC_0e8dad36985178676a96cdacdf6f5259 (ST_eeea109a56651eacd7e36d2408b5b781Structure r) {
RC_0e8dad36985178676a96cdacdf6f5259 res = new RC_0e8dad36985178676a96cdacdf6f5259 ();
res.ssSTOrderDistributionImportStruc = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_0e8dad36985178676a96cdacdf6f5259() {
OptimizedAttributes = null;
ssSTOrderDistributionImportStruc = new ST_eeea109a56651eacd7e36d2408b5b781Structure();
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
    ssSTOrderDistributionImportStruc.OptimizedAttributes = value[0];
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
ssSTOrderDistributionImportStruc.Read( r, ref index);
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
public void ReadIM(RC_0e8dad36985178676a96cdacdf6f5259 r) {
this = r;
}


public static bool operator == (RC_0e8dad36985178676a96cdacdf6f5259 a, RC_0e8dad36985178676a96cdacdf6f5259 b) {
if (a.ssSTOrderDistributionImportStruc != b.ssSTOrderDistributionImportStruc) return false;
return true;
}

public static bool operator != (RC_0e8dad36985178676a96cdacdf6f5259 a, RC_0e8dad36985178676a96cdacdf6f5259 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0e8dad36985178676a96cdacdf6f5259)) return false;
return (this == (RC_0e8dad36985178676a96cdacdf6f5259)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTOrderDistributionImportStruc.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTOrderDistributionImportStruc.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTOrderDistributionImportStruc.InternalRecursiveSave();
}


public RC_0e8dad36985178676a96cdacdf6f5259 Duplicate() {
RC_0e8dad36985178676a96cdacdf6f5259 t;
t.ssSTOrderDistributionImportStruc = (ST_eeea109a56651eacd7e36d2408b5b781Structure)this.ssSTOrderDistributionImportStruc.Duplicate();
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
if (head == "orderdistributionimportstruc") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderDistributionImportStruc")) variable.Value = ssSTOrderDistributionImportStruc; else variable.Optimized = true;
variable.SetFieldName("orderdistributionimportstruc");
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
if (key == IdOrderDistributionImportStruc) {
return ssSTOrderDistributionImportStruc;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderDistributionImportStruc.Key.AsGuid) {
return ssSTOrderDistributionImportStruc;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTOrderDistributionImportStruc.FillFromOther((IRecord) other.AttributeGet(IdOrderDistributionImportStruc));
}
} // RC_0e8dad36985178676a96cdacdf6f5259
/// <summary>
/// RecordList type <code>OrderDistributionImportStrucRecordList</code> that represents a record list
///  of <code>OrderDistributionImportStruc</code>
/// </summary>
public partial class RL_24a7f9997087be4da8bf09ab1b655746 : GenericRecordList<RC_0e8dad36985178676a96cdacdf6f5259>, IEnumerable, IEnumerator {

protected override RC_0e8dad36985178676a96cdacdf6f5259 GetElementDefaultValue() {
return new RC_0e8dad36985178676a96cdacdf6f5259();
}

public T[] ToArray<T>(Func<RC_0e8dad36985178676a96cdacdf6f5259, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_24a7f9997087be4da8bf09ab1b655746 recordList, Func<RC_0e8dad36985178676a96cdacdf6f5259, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_24a7f9997087be4da8bf09ab1b655746(RC_0e8dad36985178676a96cdacdf6f5259[] array) {
  RL_24a7f9997087be4da8bf09ab1b655746 result = new RL_24a7f9997087be4da8bf09ab1b655746();
result.InnerFromArray(array);
    return result;
}

public static RL_24a7f9997087be4da8bf09ab1b655746 ToList<T>(T[] array, Func <T, RC_0e8dad36985178676a96cdacdf6f5259> converter) {
  RL_24a7f9997087be4da8bf09ab1b655746 result = new RL_24a7f9997087be4da8bf09ab1b655746();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_24a7f9997087be4da8bf09ab1b655746 FromRestList<T>(RestList<T> restList, Func <T, RC_0e8dad36985178676a96cdacdf6f5259> converter) {
  RL_24a7f9997087be4da8bf09ab1b655746 result = new RL_24a7f9997087be4da8bf09ab1b655746();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_24a7f9997087be4da8bf09ab1b655746() : base() {
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
protected override OSList<RC_0e8dad36985178676a96cdacdf6f5259> NewList() {
return new RL_24a7f9997087be4da8bf09ab1b655746();
}


} // RL_24a7f9997087be4da8bf09ab1b655746
}

