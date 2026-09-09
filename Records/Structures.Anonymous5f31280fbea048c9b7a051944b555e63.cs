namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (DygxX6C+yUi3oFGUS1VeYw)
///  <code>RC_6c8d2ba4baf7bbeee16e4c122dfe9b38</code> that represents <code>PI_HEADER3Record</code
/// > <p>Description: </p>
/// </summary>
// Name: PI_HEADER3Record
public partial struct RC_6c8d2ba4baf7bbeee16e4c122dfe9b38 : ITypedRecord<RC_6c8d2ba4baf7bbeee16e4c122dfe9b38> {
internal static readonly GlobalObjectKey IdPI_HEADER3 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*pCuNbPe67rvhbkwSLf6bOA");

public ST_f6501ee18e176493154e18d361367656Structure ssSTPI_HEADER3;


public static implicit operator ST_f6501ee18e176493154e18d361367656Structure( RC_6c8d2ba4baf7bbeee16e4c122dfe9b38 r) {
return r.ssSTPI_HEADER3;
}

public static implicit operator RC_6c8d2ba4baf7bbeee16e4c122dfe9b38 (ST_f6501ee18e176493154e18d361367656Structure r) {
RC_6c8d2ba4baf7bbeee16e4c122dfe9b38 res = new RC_6c8d2ba4baf7bbeee16e4c122dfe9b38 ();
res.ssSTPI_HEADER3 = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_6c8d2ba4baf7bbeee16e4c122dfe9b38() {
OptimizedAttributes = null;
ssSTPI_HEADER3 = new ST_f6501ee18e176493154e18d361367656Structure();
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
    ssSTPI_HEADER3.OptimizedAttributes = value[0];
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
ssSTPI_HEADER3.Read( r, ref index);
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
public void ReadIM(RC_6c8d2ba4baf7bbeee16e4c122dfe9b38 r) {
this = r;
}


public static bool operator == (RC_6c8d2ba4baf7bbeee16e4c122dfe9b38 a, RC_6c8d2ba4baf7bbeee16e4c122dfe9b38 b) {
if (a.ssSTPI_HEADER3 != b.ssSTPI_HEADER3) return false;
return true;
}

public static bool operator != (RC_6c8d2ba4baf7bbeee16e4c122dfe9b38 a, RC_6c8d2ba4baf7bbeee16e4c122dfe9b38 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_6c8d2ba4baf7bbeee16e4c122dfe9b38)) return false;
return (this == (RC_6c8d2ba4baf7bbeee16e4c122dfe9b38)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTPI_HEADER3.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTPI_HEADER3.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTPI_HEADER3.InternalRecursiveSave();
}


public RC_6c8d2ba4baf7bbeee16e4c122dfe9b38 Duplicate() {
RC_6c8d2ba4baf7bbeee16e4c122dfe9b38 t;
t.ssSTPI_HEADER3 = (ST_f6501ee18e176493154e18d361367656Structure)this.ssSTPI_HEADER3.Duplicate();
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
if (head == "pi_header3") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_HEADER3")) variable.Value = ssSTPI_HEADER3; else variable.Optimized = true;
variable.SetFieldName("pi_header3");
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
if (key == IdPI_HEADER3) {
return ssSTPI_HEADER3;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_HEADER3.Key.AsGuid) {
return ssSTPI_HEADER3;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTPI_HEADER3.FillFromOther((IRecord) other.AttributeGet(IdPI_HEADER3));
}
} // RC_6c8d2ba4baf7bbeee16e4c122dfe9b38
/// <summary>
/// RecordList type <code>PI_HEADER3RecordList</code> that represents a record list of
///  <code>PI_HEADER3</code>
/// </summary>
public partial class RL_fe040fec46035b6ed302a35dd009e1ee : GenericRecordList<RC_6c8d2ba4baf7bbeee16e4c122dfe9b38>, IEnumerable, IEnumerator {

protected override RC_6c8d2ba4baf7bbeee16e4c122dfe9b38 GetElementDefaultValue() {
return new RC_6c8d2ba4baf7bbeee16e4c122dfe9b38();
}

public T[] ToArray<T>(Func<RC_6c8d2ba4baf7bbeee16e4c122dfe9b38, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_fe040fec46035b6ed302a35dd009e1ee recordList, Func<RC_6c8d2ba4baf7bbeee16e4c122dfe9b38, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_fe040fec46035b6ed302a35dd009e1ee(RC_6c8d2ba4baf7bbeee16e4c122dfe9b38[] array) {
  RL_fe040fec46035b6ed302a35dd009e1ee result = new RL_fe040fec46035b6ed302a35dd009e1ee();
result.InnerFromArray(array);
    return result;
}

public static RL_fe040fec46035b6ed302a35dd009e1ee ToList<T>(T[] array, Func <T, RC_6c8d2ba4baf7bbeee16e4c122dfe9b38> converter) {
  RL_fe040fec46035b6ed302a35dd009e1ee result = new RL_fe040fec46035b6ed302a35dd009e1ee();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_fe040fec46035b6ed302a35dd009e1ee FromRestList<T>(RestList<T> restList, Func <T, RC_6c8d2ba4baf7bbeee16e4c122dfe9b38> converter) {
  RL_fe040fec46035b6ed302a35dd009e1ee result = new RL_fe040fec46035b6ed302a35dd009e1ee();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_fe040fec46035b6ed302a35dd009e1ee() : base() {
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
protected override OSList<RC_6c8d2ba4baf7bbeee16e4c122dfe9b38> NewList() {
return new RL_fe040fec46035b6ed302a35dd009e1ee();
}


} // RL_fe040fec46035b6ed302a35dd009e1ee
}

