namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (9ClPl11EkU2L1qrskUWXDA)
///  <code>RC_f4d76e3d3fccb22411e2fbf1d069c4d1</code> that represents <code>ImporteSumRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ImporteSumRecord
public partial struct RC_f4d76e3d3fccb22411e2fbf1d069c4d1 : ITypedRecord<RC_f4d76e3d3fccb22411e2fbf1d069c4d1> {
internal static readonly GlobalObjectKey IdImporteSum = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*PW7X9Mw_JLIR4vvx0GnE0Q");

public decimal ssImporteSum;


public BitArray OptimizedAttributes;

public RC_f4d76e3d3fccb22411e2fbf1d069c4d1() {
OptimizedAttributes = null;
ssImporteSum = 0.0M;
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
ssImporteSum = r.ReadDecimal(index++, "ImporteSumRecord.ImporteSum", 0.0M);
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
public void ReadIM(RC_f4d76e3d3fccb22411e2fbf1d069c4d1 r) {
this = r;
}


public static bool operator == (RC_f4d76e3d3fccb22411e2fbf1d069c4d1 a, RC_f4d76e3d3fccb22411e2fbf1d069c4d1 b) {
if (a.ssImporteSum != b.ssImporteSum) return false;
return true;
}

public static bool operator != (RC_f4d76e3d3fccb22411e2fbf1d069c4d1 a, RC_f4d76e3d3fccb22411e2fbf1d069c4d1 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f4d76e3d3fccb22411e2fbf1d069c4d1)) return false;
return (this == (RC_f4d76e3d3fccb22411e2fbf1d069c4d1)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssImporteSum.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_f4d76e3d3fccb22411e2fbf1d069c4d1 Duplicate() {
RC_f4d76e3d3fccb22411e2fbf1d069c4d1 t;
t.ssImporteSum = this.ssImporteSum;
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
if (head == "importesum") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ImporteSum")) variable.Value = ssImporteSum; else variable.Optimized = true;
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
if (key == IdImporteSum) {
return ssImporteSum;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdImporteSum.Key.AsGuid) {
return ssImporteSum;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssImporteSum = (decimal) other.AttributeGet(IdImporteSum);
}
} // RC_f4d76e3d3fccb22411e2fbf1d069c4d1
/// <summary>
/// RecordList type <code>ImporteSumRecordList</code> that represents a record list of
///  <code>Decimal</code>
/// </summary>
public partial class RL_948a214f011367826beec566f5df17e6 : GenericRecordList<RC_f4d76e3d3fccb22411e2fbf1d069c4d1>, IEnumerable, IEnumerator {

protected override RC_f4d76e3d3fccb22411e2fbf1d069c4d1 GetElementDefaultValue() {
return new RC_f4d76e3d3fccb22411e2fbf1d069c4d1();
}

public T[] ToArray<T>(Func<RC_f4d76e3d3fccb22411e2fbf1d069c4d1, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_948a214f011367826beec566f5df17e6 recordList, Func<RC_f4d76e3d3fccb22411e2fbf1d069c4d1, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_948a214f011367826beec566f5df17e6(RC_f4d76e3d3fccb22411e2fbf1d069c4d1[] array) {
  RL_948a214f011367826beec566f5df17e6 result = new RL_948a214f011367826beec566f5df17e6();
result.InnerFromArray(array);
    return result;
}

public static RL_948a214f011367826beec566f5df17e6 ToList<T>(T[] array, Func <T, RC_f4d76e3d3fccb22411e2fbf1d069c4d1> converter) {
  RL_948a214f011367826beec566f5df17e6 result = new RL_948a214f011367826beec566f5df17e6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_948a214f011367826beec566f5df17e6 FromRestList<T>(RestList<T> restList, Func <T, RC_f4d76e3d3fccb22411e2fbf1d069c4d1> converter) {
  RL_948a214f011367826beec566f5df17e6 result = new RL_948a214f011367826beec566f5df17e6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_948a214f011367826beec566f5df17e6() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_f4d76e3d3fccb22411e2fbf1d069c4d1> NewList() {
return new RL_948a214f011367826beec566f5df17e6();
}


} // RL_948a214f011367826beec566f5df17e6
}

