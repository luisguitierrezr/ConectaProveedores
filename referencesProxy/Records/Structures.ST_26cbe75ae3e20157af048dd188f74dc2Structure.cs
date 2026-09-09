namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] TI_POS_Out (4Z6g7bPczEG79mdSlRAYlA)
///  <code>ST_26cbe75ae3e20157af048dd188f74dc2Structure</code> that represents <code>TI_POS_Out</code
/// > <p>Description: </p>
/// </summary>
// Name: TI_POS_Out
public partial struct ST_26cbe75ae3e20157af048dd188f74dc2Structure : ITypedRecord<ST_26cbe75ae3e20157af048dd188f74dc2Structure> {
internal static readonly GlobalObjectKey IdPARAMETRO = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*igchQZO2TE+NQSDDYFQYzg");

public string ssPARAMETRO;


public BitArray OptimizedAttributes;

public ST_26cbe75ae3e20157af048dd188f74dc2Structure() {
OptimizedAttributes = null;
ssPARAMETRO = "";
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
ssPARAMETRO = r.ReadText(index++, "TI_POS_Out.PARAMETRO", "");
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
public void ReadIM(ST_26cbe75ae3e20157af048dd188f74dc2Structure r) {
this = r;
}


public static bool operator == (ST_26cbe75ae3e20157af048dd188f74dc2Structure a, ST_26cbe75ae3e20157af048dd188f74dc2Structure b) {
if (a.ssPARAMETRO != b.ssPARAMETRO) return false;
return true;
}

public static bool operator != (ST_26cbe75ae3e20157af048dd188f74dc2Structure a, ST_26cbe75ae3e20157af048dd188f74dc2Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_26cbe75ae3e20157af048dd188f74dc2Structure)) return false;
return (this == (ST_26cbe75ae3e20157af048dd188f74dc2Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPARAMETRO.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_26cbe75ae3e20157af048dd188f74dc2Structure Duplicate() {
ST_26cbe75ae3e20157af048dd188f74dc2Structure t;
t.ssPARAMETRO = this.ssPARAMETRO;
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
if (head == "parametro") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PARAMETRO")) variable.Value = ssPARAMETRO; else variable.Optimized = true;
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
if (key == IdPARAMETRO) {
return ssPARAMETRO;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPARAMETRO.Key.AsGuid) {
return ssPARAMETRO;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPARAMETRO = (string) other.AttributeGet(IdPARAMETRO);
}
} // ST_26cbe75ae3e20157af048dd188f74dc2Structure
/// <summary>
/// RecordList type <code>TI_POS_OutList</code> that represents a record list of
///  <code>TI_POS_Out</code>
/// </summary>
public partial class RL_480c1f8575ebe73e18b76b318e3cf1a3 : GenericRecordList<ST_26cbe75ae3e20157af048dd188f74dc2Structure>, IEnumerable, IEnumerator {

protected override ST_26cbe75ae3e20157af048dd188f74dc2Structure GetElementDefaultValue() {
return new ST_26cbe75ae3e20157af048dd188f74dc2Structure();
}

public T[] ToArray<T>(Func<ST_26cbe75ae3e20157af048dd188f74dc2Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_480c1f8575ebe73e18b76b318e3cf1a3 recordList, Func<ST_26cbe75ae3e20157af048dd188f74dc2Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_480c1f8575ebe73e18b76b318e3cf1a3(ST_26cbe75ae3e20157af048dd188f74dc2Structure[] array) {
  RL_480c1f8575ebe73e18b76b318e3cf1a3 result = new RL_480c1f8575ebe73e18b76b318e3cf1a3();
result.InnerFromArray(array);
    return result;
}

public static RL_480c1f8575ebe73e18b76b318e3cf1a3 ToList<T>(T[] array, Func <T, ST_26cbe75ae3e20157af048dd188f74dc2Structure> converter) {
  RL_480c1f8575ebe73e18b76b318e3cf1a3 result = new RL_480c1f8575ebe73e18b76b318e3cf1a3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_480c1f8575ebe73e18b76b318e3cf1a3 FromRestList<T>(RestList<T> restList, Func <T, ST_26cbe75ae3e20157af048dd188f74dc2Structure> converter) {
  RL_480c1f8575ebe73e18b76b318e3cf1a3 result = new RL_480c1f8575ebe73e18b76b318e3cf1a3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_480c1f8575ebe73e18b76b318e3cf1a3() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_26cbe75ae3e20157af048dd188f74dc2Structure> NewList() {
return new RL_480c1f8575ebe73e18b76b318e3cf1a3();
}


} // RL_480c1f8575ebe73e18b76b318e3cf1a3
}

