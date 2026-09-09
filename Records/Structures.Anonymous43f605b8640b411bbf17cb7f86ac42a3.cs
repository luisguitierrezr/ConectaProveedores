namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (uAX2QwtkG0G_F8t_hqxCow)
///  <code>RC_4d06af040e4a89ed9c35b745b328b97d</code> that represent
/// s <code>CurrencyTotalAmountRecord</code> <p>Description: </p>
/// </summary>
// Name: CurrencyTotalAmountRecord
public partial struct RC_4d06af040e4a89ed9c35b745b328b97d : ITypedRecord<RC_4d06af040e4a89ed9c35b745b328b97d> {
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*L_BoBOY11sygkvMhxdiojg");
internal static readonly GlobalObjectKey IdTotalAmount = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*uNH36LeiF7N+j_UOkhiw_A");

public EN_327b52812b8badb247bde4975c10d441EntityRecord ssENCurrency;

public decimal ssTotalAmount;


public BitArray OptimizedAttributes;

public RC_4d06af040e4a89ed9c35b745b328b97d() {
OptimizedAttributes = null;
ssENCurrency = new EN_327b52812b8badb247bde4975c10d441EntityRecord();
ssTotalAmount = 0.0M;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCurrency.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENCurrency.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENCurrency.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENCurrency.Read( r, ref index);
ssTotalAmount = r.ReadDecimal(index++, "CurrencyTotalAmountRecord.TotalAmount", 0.0M);
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
public void ReadIM(RC_4d06af040e4a89ed9c35b745b328b97d r) {
this = r;
}


public static bool operator == (RC_4d06af040e4a89ed9c35b745b328b97d a, RC_4d06af040e4a89ed9c35b745b328b97d b) {
if (a.ssENCurrency != b.ssENCurrency) return false;
if (a.ssTotalAmount != b.ssTotalAmount) return false;
return true;
}

public static bool operator != (RC_4d06af040e4a89ed9c35b745b328b97d a, RC_4d06af040e4a89ed9c35b745b328b97d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_4d06af040e4a89ed9c35b745b328b97d)) return false;
return (this == (RC_4d06af040e4a89ed9c35b745b328b97d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCurrency.GetHashCode()
 ^ ssTotalAmount.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCurrency.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCurrency.InternalRecursiveSave();
}


public RC_4d06af040e4a89ed9c35b745b328b97d Duplicate() {
RC_4d06af040e4a89ed9c35b745b328b97d t;
t.ssENCurrency = (EN_327b52812b8badb247bde4975c10d441EntityRecord)this.ssENCurrency.Duplicate();
t.ssTotalAmount = this.ssTotalAmount;
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
if (head == "currency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Currency")) variable.Value = ssENCurrency; else variable.Optimized = true;
variable.SetFieldName("currency");
} else if (head == "totalamount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalAmount")) variable.Value = ssTotalAmount; else variable.Optimized = true;
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
if (key == IdCurrency) {
return ssENCurrency;
}
if (key == IdTotalAmount) {
return ssTotalAmount;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCurrency.Key.AsGuid) {
return ssENCurrency;
}
if (attributeKey == IdTotalAmount.Key.AsGuid) {
return ssTotalAmount;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCurrency.FillFromOther((IRecord) other.AttributeGet(IdCurrency));
ssTotalAmount = (decimal) other.AttributeGet(IdTotalAmount);
}
} // RC_4d06af040e4a89ed9c35b745b328b97d
/// <summary>
/// RecordList type <code>CurrencyTotalAmountRecordList</code> that represents a record list of
///  <code>Currency, Decimal</code>
/// </summary>
public partial class RL_8e14ec72aef34f71202ab5fcdfb4c9b8 : GenericRecordList<RC_4d06af040e4a89ed9c35b745b328b97d>, IEnumerable, IEnumerator {

protected override RC_4d06af040e4a89ed9c35b745b328b97d GetElementDefaultValue() {
return new RC_4d06af040e4a89ed9c35b745b328b97d();
}

public T[] ToArray<T>(Func<RC_4d06af040e4a89ed9c35b745b328b97d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8e14ec72aef34f71202ab5fcdfb4c9b8 recordList, Func<RC_4d06af040e4a89ed9c35b745b328b97d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8e14ec72aef34f71202ab5fcdfb4c9b8(RC_4d06af040e4a89ed9c35b745b328b97d[] array) {
  RL_8e14ec72aef34f71202ab5fcdfb4c9b8 result = new RL_8e14ec72aef34f71202ab5fcdfb4c9b8();
result.InnerFromArray(array);
    return result;
}

public static RL_8e14ec72aef34f71202ab5fcdfb4c9b8 ToList<T>(T[] array, Func <T, RC_4d06af040e4a89ed9c35b745b328b97d> converter) {
  RL_8e14ec72aef34f71202ab5fcdfb4c9b8 result = new RL_8e14ec72aef34f71202ab5fcdfb4c9b8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8e14ec72aef34f71202ab5fcdfb4c9b8 FromRestList<T>(RestList<T> restList, Func <T, RC_4d06af040e4a89ed9c35b745b328b97d> converter) {
  RL_8e14ec72aef34f71202ab5fcdfb4c9b8 result = new RL_8e14ec72aef34f71202ab5fcdfb4c9b8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8e14ec72aef34f71202ab5fcdfb4c9b8() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_4d06af040e4a89ed9c35b745b328b97d> NewList() {
return new RL_8e14ec72aef34f71202ab5fcdfb4c9b8();
}


} // RL_8e14ec72aef34f71202ab5fcdfb4c9b8
}

