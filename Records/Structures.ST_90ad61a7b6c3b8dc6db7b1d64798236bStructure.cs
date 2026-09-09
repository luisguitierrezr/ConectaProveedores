namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] ZMXFFIMF_RETEN_PROVEEDORESReq (bDAO2ZbBcEG2_D4ZQGQjkw)
///  <code>ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure</code> that represent
/// s <code>ZMXFFIMF_RETEN_PROVEEDORESReq</code> <p>Description: ZMXFFIMF_RETEN_PROVEEDORESReq</p>
/// </summary>
// Name: ZMXFFIMF_RETEN_PROVEEDORESReq
public partial struct ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure : ITypedRecord<ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure> {
internal static readonly GlobalObjectKey IdPI_BUKRS = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*zH4SkitSYkiZ2CHc3juk_Q");
internal static readonly GlobalObjectKey IdPI_VENDORNO = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*6OObf7e6JEqJxMosy9Qs8Q");
internal static readonly GlobalObjectKey IdTI_RETENCIONES_In = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*kn6JPe_Tr0+jn8Mt7KJ_pw");

public string ssPI_BUKRS;

public string ssPI_VENDORNO;

public RL_725bda958021cd78431a036d1def2d7e ssTI_RETENCIONES_In;


public BitArray OptimizedAttributes;

public ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure() {
OptimizedAttributes = null;
ssPI_BUKRS = "";
ssPI_VENDORNO = "";
ssTI_RETENCIONES_In = new RL_725bda958021cd78431a036d1def2d7e();
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
ssPI_BUKRS = r.ReadText(index++, "ZMXFFIMF_RETEN_PROVEEDORESReq.PI_BUKRS", "");
ssPI_VENDORNO = r.ReadText(index++, "ZMXFFIMF_RETEN_PROVEEDORESReq.PI_VENDORNO", "");
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
public void ReadIM(ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure r) {
this = r;
}


public static bool operator == (ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure a, ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure b) {
if (a.ssPI_BUKRS != b.ssPI_BUKRS) return false;
if (a.ssPI_VENDORNO != b.ssPI_VENDORNO) return false;
if (a.ssTI_RETENCIONES_In != b.ssTI_RETENCIONES_In) return false;
return true;
}

public static bool operator != (ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure a, ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure)) return false;
return (this == (ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPI_BUKRS.GetHashCode()
 ^ ssPI_VENDORNO.GetHashCode()
 ^ ssTI_RETENCIONES_In.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssTI_RETENCIONES_In.RecursiveReset();
}

public void InternalRecursiveSave() {
ssTI_RETENCIONES_In.InternalRecursiveSave();
}


public ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure Duplicate() {
ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure t;
t.ssPI_BUKRS = this.ssPI_BUKRS;
t.ssPI_VENDORNO = this.ssPI_VENDORNO;
t.ssTI_RETENCIONES_In = (RL_725bda958021cd78431a036d1def2d7e)this.ssTI_RETENCIONES_In.Duplicate();
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
if (head == "pi_bukrs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_BUKRS")) variable.Value = ssPI_BUKRS; else variable.Optimized = true;
} else if (head == "pi_vendorno") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_VENDORNO")) variable.Value = ssPI_VENDORNO; else variable.Optimized = true;
} else if (head == "ti_retenciones_in") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TI_RETENCIONES_In")) variable.Value = ssTI_RETENCIONES_In; else variable.Optimized = true;
variable.SetFieldName("ti_retenciones_in");
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
if (key == IdPI_BUKRS) {
return ssPI_BUKRS;
}
if (key == IdPI_VENDORNO) {
return ssPI_VENDORNO;
}
if (key == IdTI_RETENCIONES_In) {
return ssTI_RETENCIONES_In;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_BUKRS.Key.AsGuid) {
return ssPI_BUKRS;
}
if (attributeKey == IdPI_VENDORNO.Key.AsGuid) {
return ssPI_VENDORNO;
}
if (attributeKey == IdTI_RETENCIONES_In.Key.AsGuid) {
return ssTI_RETENCIONES_In;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPI_BUKRS = (string) other.AttributeGet(IdPI_BUKRS);
ssPI_VENDORNO = (string) other.AttributeGet(IdPI_VENDORNO);
ssTI_RETENCIONES_In = new RL_725bda958021cd78431a036d1def2d7e();
ssTI_RETENCIONES_In.FillFromOther((IOSList) other.AttributeGet(IdTI_RETENCIONES_In));
}
} // ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure
/// <summary>
/// RecordList type <code>ZMXFFIMF_RETEN_PROVEEDORESReqList</code> that represents a record list of
///  <code>ZMXFFIMF_RETEN_PROVEEDORESReq</code>
/// </summary>
public partial class RL_8232ef667bf972bd1cc1fb4cfeb60fcf : GenericRecordList<ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure>, IEnumerable, IEnumerator {

protected override ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure GetElementDefaultValue() {
return new ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure();
}

public T[] ToArray<T>(Func<ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8232ef667bf972bd1cc1fb4cfeb60fcf recordList, Func<ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8232ef667bf972bd1cc1fb4cfeb60fcf(ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure[] array) {
  RL_8232ef667bf972bd1cc1fb4cfeb60fcf result = new RL_8232ef667bf972bd1cc1fb4cfeb60fcf();
result.InnerFromArray(array);
    return result;
}

public static RL_8232ef667bf972bd1cc1fb4cfeb60fcf ToList<T>(T[] array, Func <T, ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure> converter) {
  RL_8232ef667bf972bd1cc1fb4cfeb60fcf result = new RL_8232ef667bf972bd1cc1fb4cfeb60fcf();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8232ef667bf972bd1cc1fb4cfeb60fcf FromRestList<T>(RestList<T> restList, Func <T, ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure> converter) {
  RL_8232ef667bf972bd1cc1fb4cfeb60fcf result = new RL_8232ef667bf972bd1cc1fb4cfeb60fcf();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8232ef667bf972bd1cc1fb4cfeb60fcf() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure> NewList() {
return new RL_8232ef667bf972bd1cc1fb4cfeb60fcf();
}


} // RL_8232ef667bf972bd1cc1fb4cfeb60fcf
}

