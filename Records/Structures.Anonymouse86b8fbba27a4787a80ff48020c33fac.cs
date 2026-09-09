namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (u49r6Hqih0eoD_SAIMM_rA)
///  <code>RC_46775da414dc909821822de65ba32d4b</code> that represent
/// s <code>SymbolImporteenMLSumRecord</code> <p>Description: </p>
/// </summary>
// Name: SymbolImporteenMLSumRecord
public partial struct RC_46775da414dc909821822de65ba32d4b : ITypedRecord<RC_46775da414dc909821822de65ba32d4b> {
internal static readonly GlobalObjectKey IdSymbol = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*amah9FlvmQCJGwIiB0uD9Q");
internal static readonly GlobalObjectKey IdImporteenMLSum = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*VSvoxj7FiVkczt+nY3rCzQ");

public string ssSymbol;

public decimal ssImporteenMLSum;


public BitArray OptimizedAttributes;

public RC_46775da414dc909821822de65ba32d4b() {
OptimizedAttributes = null;
ssSymbol = "";
ssImporteenMLSum = 0.0M;
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
ssSymbol = r.ReadText(index++, "SymbolImporteenMLSumRecord.Symbol", "");
ssImporteenMLSum = r.ReadDecimal(index++, "SymbolImporteenMLSumRecord.ImporteenMLSum", 0.0M);
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
public void ReadIM(RC_46775da414dc909821822de65ba32d4b r) {
this = r;
}


public static bool operator == (RC_46775da414dc909821822de65ba32d4b a, RC_46775da414dc909821822de65ba32d4b b) {
if (a.ssSymbol != b.ssSymbol) return false;
if (a.ssImporteenMLSum != b.ssImporteenMLSum) return false;
return true;
}

public static bool operator != (RC_46775da414dc909821822de65ba32d4b a, RC_46775da414dc909821822de65ba32d4b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_46775da414dc909821822de65ba32d4b)) return false;
return (this == (RC_46775da414dc909821822de65ba32d4b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSymbol.GetHashCode()
 ^ ssImporteenMLSum.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_46775da414dc909821822de65ba32d4b Duplicate() {
RC_46775da414dc909821822de65ba32d4b t;
t.ssSymbol = this.ssSymbol;
t.ssImporteenMLSum = this.ssImporteenMLSum;
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
if (head == "symbol") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Symbol")) variable.Value = ssSymbol; else variable.Optimized = true;
} else if (head == "importeenmlsum") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ImporteenMLSum")) variable.Value = ssImporteenMLSum; else variable.Optimized = true;
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
if (key == IdSymbol) {
return ssSymbol;
}
if (key == IdImporteenMLSum) {
return ssImporteenMLSum;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSymbol.Key.AsGuid) {
return ssSymbol;
}
if (attributeKey == IdImporteenMLSum.Key.AsGuid) {
return ssImporteenMLSum;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSymbol = (string) other.AttributeGet(IdSymbol);
ssImporteenMLSum = (decimal) other.AttributeGet(IdImporteenMLSum);
}
} // RC_46775da414dc909821822de65ba32d4b
/// <summary>
/// RecordList type <code>SymbolImporteenMLSumRecordList</code> that represents a record list of
///  <code>Text, Decimal</code>
/// </summary>
public partial class RL_8af3ce06aba4cbfdf62ee5d0bb265fe6 : GenericRecordList<RC_46775da414dc909821822de65ba32d4b>, IEnumerable, IEnumerator {

protected override RC_46775da414dc909821822de65ba32d4b GetElementDefaultValue() {
return new RC_46775da414dc909821822de65ba32d4b();
}

public T[] ToArray<T>(Func<RC_46775da414dc909821822de65ba32d4b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8af3ce06aba4cbfdf62ee5d0bb265fe6 recordList, Func<RC_46775da414dc909821822de65ba32d4b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8af3ce06aba4cbfdf62ee5d0bb265fe6(RC_46775da414dc909821822de65ba32d4b[] array) {
  RL_8af3ce06aba4cbfdf62ee5d0bb265fe6 result = new RL_8af3ce06aba4cbfdf62ee5d0bb265fe6();
result.InnerFromArray(array);
    return result;
}

public static RL_8af3ce06aba4cbfdf62ee5d0bb265fe6 ToList<T>(T[] array, Func <T, RC_46775da414dc909821822de65ba32d4b> converter) {
  RL_8af3ce06aba4cbfdf62ee5d0bb265fe6 result = new RL_8af3ce06aba4cbfdf62ee5d0bb265fe6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8af3ce06aba4cbfdf62ee5d0bb265fe6 FromRestList<T>(RestList<T> restList, Func <T, RC_46775da414dc909821822de65ba32d4b> converter) {
  RL_8af3ce06aba4cbfdf62ee5d0bb265fe6 result = new RL_8af3ce06aba4cbfdf62ee5d0bb265fe6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8af3ce06aba4cbfdf62ee5d0bb265fe6() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_46775da414dc909821822de65ba32d4b> NewList() {
return new RL_8af3ce06aba4cbfdf62ee5d0bb265fe6();
}


} // RL_8af3ce06aba4cbfdf62ee5d0bb265fe6
}

