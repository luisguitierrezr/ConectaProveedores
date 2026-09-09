namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (lAk2N_LxMU+Gs2SeaT4qvA)
///  <code>RC_0d0a8c249b32cb294d6fd424b17f5c4d</code> that represent
/// s <code>OrderMainTabNumberTelcelDirectionRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderMainTabNumberTelcelDirectionRegionRecord
public partial struct RC_0d0a8c249b32cb294d6fd424b17f5c4d : ITypedRecord<RC_0d0a8c249b32cb294d6fd424b17f5c4d> {
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdTabNumber = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*MF2ru18vD6v1KTbw92mMKw");
internal static readonly GlobalObjectKey IdTelcelDirection = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*GJPF90MHwEDiMLq9XqYvtQ");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public int ssTabNumber;

public EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord ssENTelcelDirection;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_0d0a8c249b32cb294d6fd424b17f5c4d() {
OptimizedAttributes = null;
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssTabNumber = 0;
ssENTelcelDirection = new EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(29,false);
    all[1] = new BitArray(7,false);
    all[2] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENTelcelDirection.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENOrderMain.OptimizedAttributes = value[0];
    ssENTelcelDirection.OptimizedAttributes = value[1];
    ssENRegion.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENOrderMain.OptimizedAttributes;
    all[1] = ssENTelcelDirection.OptimizedAttributes;
    all[2] = ssENRegion.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderMain.Read( r, ref index);
ssTabNumber = r.ReadInteger(index++, "OrderMainTabNumberTelcelDirectionRegionRecord.TabNumber", 0);
ssENTelcelDirection.Read( r, ref index);
ssENRegion.Read( r, ref index);
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
public void ReadIM(RC_0d0a8c249b32cb294d6fd424b17f5c4d r) {
this = r;
}


public static bool operator == (RC_0d0a8c249b32cb294d6fd424b17f5c4d a, RC_0d0a8c249b32cb294d6fd424b17f5c4d b) {
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssTabNumber != b.ssTabNumber) return false;
if (a.ssENTelcelDirection != b.ssENTelcelDirection) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_0d0a8c249b32cb294d6fd424b17f5c4d a, RC_0d0a8c249b32cb294d6fd424b17f5c4d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0d0a8c249b32cb294d6fd424b17f5c4d)) return false;
return (this == (RC_0d0a8c249b32cb294d6fd424b17f5c4d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssTabNumber.GetHashCode()
 ^ ssENTelcelDirection.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderMain.RecursiveReset();
ssENTelcelDirection.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderMain.InternalRecursiveSave();
ssENTelcelDirection.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_0d0a8c249b32cb294d6fd424b17f5c4d Duplicate() {
RC_0d0a8c249b32cb294d6fd424b17f5c4d t;
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssTabNumber = this.ssTabNumber;
t.ssENTelcelDirection = (EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord)this.ssENTelcelDirection.Duplicate();
t.ssENRegion = (EN_31f501c551d210017fcb34b5237e3390EntityRecord)this.ssENRegion.Duplicate();
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
if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "tabnumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TabNumber")) variable.Value = ssTabNumber; else variable.Optimized = true;
} else if (head == "telceldirection") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TelcelDirection")) variable.Value = ssENTelcelDirection; else variable.Optimized = true;
variable.SetFieldName("telceldirection");
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssENRegion; else variable.Optimized = true;
variable.SetFieldName("region");
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
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdTabNumber) {
return ssTabNumber;
}
if (key == IdTelcelDirection) {
return ssENTelcelDirection;
}
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdTabNumber.Key.AsGuid) {
return ssTabNumber;
}
if (attributeKey == IdTelcelDirection.Key.AsGuid) {
return ssENTelcelDirection;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssTabNumber = (int) other.AttributeGet(IdTabNumber);
ssENTelcelDirection.FillFromOther((IRecord) other.AttributeGet(IdTelcelDirection));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_0d0a8c249b32cb294d6fd424b17f5c4d
/// <summary>
/// RecordList type <code>OrderMainTabNumberTelcelDirectionRegionRecordList</code> that represents a
///  record list of <code>OrderMain, Integer, TelcelDirection, Region</code>
/// </summary>
public partial class RL_e927228371816df5f25c7471220fa6c2 : GenericRecordList<RC_0d0a8c249b32cb294d6fd424b17f5c4d>, IEnumerable, IEnumerator {

protected override RC_0d0a8c249b32cb294d6fd424b17f5c4d GetElementDefaultValue() {
return new RC_0d0a8c249b32cb294d6fd424b17f5c4d();
}

public T[] ToArray<T>(Func<RC_0d0a8c249b32cb294d6fd424b17f5c4d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e927228371816df5f25c7471220fa6c2 recordList, Func<RC_0d0a8c249b32cb294d6fd424b17f5c4d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e927228371816df5f25c7471220fa6c2(RC_0d0a8c249b32cb294d6fd424b17f5c4d[] array) {
  RL_e927228371816df5f25c7471220fa6c2 result = new RL_e927228371816df5f25c7471220fa6c2();
result.InnerFromArray(array);
    return result;
}

public static RL_e927228371816df5f25c7471220fa6c2 ToList<T>(T[] array, Func <T, RC_0d0a8c249b32cb294d6fd424b17f5c4d> converter) {
  RL_e927228371816df5f25c7471220fa6c2 result = new RL_e927228371816df5f25c7471220fa6c2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e927228371816df5f25c7471220fa6c2 FromRestList<T>(RestList<T> restList, Func <T, RC_0d0a8c249b32cb294d6fd424b17f5c4d> converter) {
  RL_e927228371816df5f25c7471220fa6c2 result = new RL_e927228371816df5f25c7471220fa6c2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e927228371816df5f25c7471220fa6c2() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(29,false);
def[1] = new BitArray(7,false);
def[2] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_0d0a8c249b32cb294d6fd424b17f5c4d> NewList() {
return new RL_e927228371816df5f25c7471220fa6c2();
}


} // RL_e927228371816df5f25c7471220fa6c2
}

