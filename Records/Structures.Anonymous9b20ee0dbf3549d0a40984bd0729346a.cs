namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (De4gmzW_0EmkCYS9Byk0ag)
///  <code>RC_ee67c405f78e15f46603b032a29fae74</code> that represents <code>TextValueRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: TextValueRecord
public partial struct RC_ee67c405f78e15f46603b032a29fae74 : ITypedRecord<RC_ee67c405f78e15f46603b032a29fae74> {
internal static readonly GlobalObjectKey IdText = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*W1Fhyhtfo4H2OnL2lpOuNg");
internal static readonly GlobalObjectKey IdValue = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_IYT9FQnxC1XBxh0QSN10g");

public string ssText;

public decimal ssValue;


public BitArray OptimizedAttributes;

public RC_ee67c405f78e15f46603b032a29fae74() {
OptimizedAttributes = null;
ssText = "";
ssValue = 0.0M;
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
ssText = r.ReadText(index++, "TextValueRecord.Text", "");
ssValue = r.ReadDecimal(index++, "TextValueRecord.Value", 0.0M);
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
public void ReadIM(RC_ee67c405f78e15f46603b032a29fae74 r) {
this = r;
}


public static bool operator == (RC_ee67c405f78e15f46603b032a29fae74 a, RC_ee67c405f78e15f46603b032a29fae74 b) {
if (a.ssText != b.ssText) return false;
if (a.ssValue != b.ssValue) return false;
return true;
}

public static bool operator != (RC_ee67c405f78e15f46603b032a29fae74 a, RC_ee67c405f78e15f46603b032a29fae74 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ee67c405f78e15f46603b032a29fae74)) return false;
return (this == (RC_ee67c405f78e15f46603b032a29fae74)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssText.GetHashCode()
 ^ ssValue.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_ee67c405f78e15f46603b032a29fae74 Duplicate() {
RC_ee67c405f78e15f46603b032a29fae74 t;
t.ssText = this.ssText;
t.ssValue = this.ssValue;
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
if (head == "text") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Text")) variable.Value = ssText; else variable.Optimized = true;
} else if (head == "value") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Value")) variable.Value = ssValue; else variable.Optimized = true;
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
if (key == IdText) {
return ssText;
}
if (key == IdValue) {
return ssValue;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdText.Key.AsGuid) {
return ssText;
}
if (attributeKey == IdValue.Key.AsGuid) {
return ssValue;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssText = (string) other.AttributeGet(IdText);
ssValue = (decimal) other.AttributeGet(IdValue);
}
} // RC_ee67c405f78e15f46603b032a29fae74
/// <summary>
/// RecordList type <code>TextValueRecordList</code> that represents a record list of <code>Text,
///  Decimal</code>
/// </summary>
public partial class RL_88196b1a2e1928c27f6fa3b58c10c14d : GenericRecordList<RC_ee67c405f78e15f46603b032a29fae74>, IEnumerable, IEnumerator {

protected override RC_ee67c405f78e15f46603b032a29fae74 GetElementDefaultValue() {
return new RC_ee67c405f78e15f46603b032a29fae74();
}

public T[] ToArray<T>(Func<RC_ee67c405f78e15f46603b032a29fae74, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_88196b1a2e1928c27f6fa3b58c10c14d recordList, Func<RC_ee67c405f78e15f46603b032a29fae74, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_88196b1a2e1928c27f6fa3b58c10c14d(RC_ee67c405f78e15f46603b032a29fae74[] array) {
  RL_88196b1a2e1928c27f6fa3b58c10c14d result = new RL_88196b1a2e1928c27f6fa3b58c10c14d();
result.InnerFromArray(array);
    return result;
}

public static RL_88196b1a2e1928c27f6fa3b58c10c14d ToList<T>(T[] array, Func <T, RC_ee67c405f78e15f46603b032a29fae74> converter) {
  RL_88196b1a2e1928c27f6fa3b58c10c14d result = new RL_88196b1a2e1928c27f6fa3b58c10c14d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_88196b1a2e1928c27f6fa3b58c10c14d FromRestList<T>(RestList<T> restList, Func <T, RC_ee67c405f78e15f46603b032a29fae74> converter) {
  RL_88196b1a2e1928c27f6fa3b58c10c14d result = new RL_88196b1a2e1928c27f6fa3b58c10c14d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_88196b1a2e1928c27f6fa3b58c10c14d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_ee67c405f78e15f46603b032a29fae74> NewList() {
return new RL_88196b1a2e1928c27f6fa3b58c10c14d();
}


} // RL_88196b1a2e1928c27f6fa3b58c10c14d
}

